using Microsoft.AspNetCore.Mvc;

namespace NODUS.Models
{
    public class Tarea : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
