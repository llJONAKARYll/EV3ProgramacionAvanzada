using EV3ProgramacionAvanzada.Database;
using EV3ProgramacionAvanzada.Models;
using Microsoft.AspNetCore.Mvc;

namespace EV3ProgramacionAvanzada.Controllers
{
    public class usuarioController : Controller
    {
        private readonly AplicationDbContext _context;

        public usuarioController(AplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var usuarios = _context.usuarios.ToList();
            return View(usuarios);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }
    }
}
