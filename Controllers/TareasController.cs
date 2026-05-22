using Microsoft.AspNetCore.Mvc;

namespace NODUS.Controllers
{
    public class TareasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
