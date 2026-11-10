using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfOrderSystem.Data;
using SelfOrderSystem.Models;
using SelfOrderSystem.Services;
using SelfOrderSystem.ViewModels;
using System.Numerics;

namespace SelfOrderSystem.Controllers;

public class OrdersController : Controller {
    private readonly AppDbContext _db; // 商品と注文のDB 操作
    private readonly CartService _cart; // Session 内のカート操作

    public OrdersController(AppDbContext db, CartService cart) {
        _db = db;
        _cart = cart;
    }

    [HttpGet]
    public IActionResult Checkout() {
        var items = _cart.GetItems(); // Session からカートを読む
        if (items.Count == 0) {
            return RedirectToAction("Index", "Menu");
        }
        return View(new CheckoutViewModel { Items = items });
    }


  

    [HttpGet]
    public async Task<IActionResult> Complete(Guid id) {
        var order = await LoadPublicOrderAsync(id);
        return order == null ? NotFound() : View(order);
    }
    [HttpGet]
    public async Task<IActionResult> Status(Guid id) {
        var order = await LoadPublicOrderAsync(id);
        return order == null ? NotFound() : View(order);
    }
    private Task<Order?> LoadPublicOrderAsync(Guid publicId) {
        return _db.Orders.AsNoTracking()
        .Include(o => o.Items)
        .ThenInclude(i => i.Product)
        .SingleOrDefaultAsync(o => o.PublicId == publicId);
    }

}
