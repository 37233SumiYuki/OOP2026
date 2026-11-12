using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfOrderSystem.Data;
using SelfOrderSystem.Models;

using Microsoft.AspNetCore.SignalR;
using SelfOrderSystem.Hubs;

namespace SelfOrderSystem.Controllers;


public class StaffController : Controller {
    private readonly AppDbContext _db;
    private readonly IHubContext<StaffOrdersHub> _hubContext;
    private readonly ILogger<StaffController> _logger;


    public StaffController(AppDbContext db,
     IHubContext<StaffOrdersHub> hubContext,
     ILogger<StaffController> logger) {
        _db = db; // 既存のDB操作 
        _hubContext = hubContext; // SignalRで通知 
        _logger = logger; // 通知エラーを記録 
    }

    [HttpGet]
    public async Task<IActionResult> Index() {
        var orders = await _db.Orders
            .AsNoTracking()
            .Include(o => o.Items)
            .ThenInclude(i => i.Product)
            .OrderByDescending(o => o.OrderedAtUtc)
            .Take(50)
            .ToListAsync();

        return View(orders);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Advance(int id) {
        var order = await _db.Orders.FindAsync(id);

        if (order == null) {
            return NotFound();
        }

        if (order.Status == OrderStatus.New) {
            order.Status = OrderStatus.Accepted;
        } else if (order.Status == OrderStatus.Accepted) {
            order.Status = OrderStatus.Cooking;
        } else if (order.Status == OrderStatus.Cooking) {
            order.Status = OrderStatus.Served;
        }

        try {
            // この注文を見ているお客様だけに通知 
            await _hubContext.Clients
                .Group($"order-{order.PublicId:N}")
                .SendAsync("OrderStatusChanged");

            // 他の店舗画面にも一覧変更を通知 
            await _hubContext.Clients.All.SendAsync("OrdersChanged");
        }
        catch (Exception ex) {
            // 保存した注文状態は取り消さない 
            _logger.LogWarning(ex, "状態更新の通知に失敗");
        }
        return RedirectToAction(nameof(Index));
    }
}