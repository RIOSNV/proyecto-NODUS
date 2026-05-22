using Microsoft.AspNetCore.Mvc;

namespace NODUS.Controllers
{
    public class MateriasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
