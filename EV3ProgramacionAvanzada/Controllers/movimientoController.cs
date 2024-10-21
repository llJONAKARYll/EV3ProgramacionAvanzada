using EV3ProgramacionAvanzada.Database;
using Microsoft.AspNetCore.Mvc;

namespace EV3ProgramacionAvanzada.Controllers
{
    public class movimientoController : Controller
    {
        private readonly AplicationDbContext _context;

        public movimientoController(AplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var movements = _context.movimientos.Include(m => m.herramientaId).Include(m => m.UserId).ToList();
            return View(movements);
        }
    }
}
