using LaptoManiaOficial.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LaptoManiaOficial.Controllers
{
    public class MainController : Controller
    {
        private readonly MiContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MainController(MiContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // GET: Equipoes
        public async Task<IActionResult> Index()
        {
            return _context.Equipos != null ?
                        View(await _context.Equipos.ToListAsync()) :
                        Problem("Entity set 'MiContext.Equipos'  is null.");
        }
    }
}