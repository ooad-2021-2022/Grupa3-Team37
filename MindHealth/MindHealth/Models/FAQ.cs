using Microsoft.AspNetCore.Mvc;

namespace MindHealth.Models
{
    public class FAQ : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
