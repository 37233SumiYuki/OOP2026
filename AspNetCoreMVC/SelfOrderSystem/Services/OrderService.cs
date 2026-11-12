using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SelfOrderSystem.Data;
using SelfOrderSystem.Hubs;
using SelfOrderSystem.Models;

namespace SelfOrderSystem.Services;

public class OrderService : IOrderService
{
    // DB操作
    private readonly AppDbContext _db;

    // SignalR通知
    private readonly IHubContext<StaffOrdersHub> _hubContext;

    // ログ出力
    private readonly ILogger<OrderService> _logger;

    public OrderService(
        AppDbContext db,
        IHubContext<StaffOrdersHub> hubContext,
        ILogger<OrderService> logger)
    {
        _db = db;
        _hubContext = hubContext;
        _logger = logger;
    }

    public async Task<PlaceOrderResult> PlaceAsync(
        List<CartItem> cartItems,
        int tableNumber)
    {
        var result = new PlaceOrderResult();

        // カートが空
        if (cartItems.Count == 0)
        {
            result.Errors.Add("カートが空です");
            return result;
        }

        // テーブル番号チェック
        if (tableNumber < 1 || tableNumber > 999)
        {
            result.Errors.Add("テーブル番号は1～999にしてください");
            return result;
        }

        // 商品ID一覧
        var ids = cartItems
            .Select(x => x.ProductId)
            .Distinct()
            .ToList();

        // DBから商品取得
        var products = await _db.Products
            .AsNoTracking()
            .Where(p => ids.Contains(p.Id) && p.IsActive)
            .ToDictionaryAsync(p => p.Id);

        // 入力チェック
        foreach (var item in cartItems)
        {
            if (!products.TryGetValue(item.ProductId, out var product))
            {
                result.Errors.Add("注文できない商品があります");
                continue;
            }

            if (product.IsSoldOut)
            {
                result.Errors.Add($"{product.Name}は売り切れです");
            }

            if (item.Quantity < 1 || item.Quantity > 99)
            {
                result.Errors.Add("数量は1～99にしてください");
            }

            if (product.Price != item.UnitPrice)
            {
                result.Errors.Add($"{product.Name}の価格が変更されました");
            }
        }

        // エラーがあれば中断
        if (result.Errors.Count > 0)
        {
            return result;
        }

        // 注文作成
        var order = new Order
        {
            TableNumber = tableNumber,
            OrderedAtUtc = DateTimeOffset.UtcNow,
            Status = OrderStatus.New
        };

        // 注文明細作成
        foreach (var item in cartItems)
        {
            var product = products[item.ProductId];

            order.Items.Add(new OrderItem
            {
                ProductId = product.Id,
                Quantity = item.Quantity,
                UnitPrice = product.Price
            });
        }

        // 保存
        _db.Orders.Add(order);
        await _db.SaveChangesAsync();

        result.PublicId = order.PublicId;

        try
        {
            // 店舗画面へ更新通知
            await _hubContext.Clients.All.SendAsync("OrdersChanged");
        }
        catch (Exception ex)
        {
            // 通知失敗でも注文は成功扱い
            _logger.LogWarning(ex, "注文一覧への通知に失敗");
        }

        return result;
    }
}