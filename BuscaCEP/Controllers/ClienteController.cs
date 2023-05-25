using BuscaCEP.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BuscaCEP.Controllers;

public class ClienteController : Controller
{
    private readonly ApplicationDbContext _context;

    public ClienteController(ApplicationDbContext context) => _context = context;

    public async Task<IActionResult> Index()
    {
        return View(await _context.Clientes.ToListAsync());
    }
}
