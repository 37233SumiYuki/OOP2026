using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfOrderSystem.Data;
using SelfOrderSystem.Models;

namespace SelfOrderSystem.Controllers;

public class StaffController : Controller {
    private readonly AppDbContext _db;

    public StaffController(AppDbContext db) {
        _db = db;
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

        await _db.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }
}