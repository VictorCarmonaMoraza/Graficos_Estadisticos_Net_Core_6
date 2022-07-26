using Microsoft.AspNetCore.Mvc;

namespace GraficosNetCore.Controllers
{
    public class GraficoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
