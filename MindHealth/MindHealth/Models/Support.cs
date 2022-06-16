using Microsoft.AspNetCore.Mvc;

namespace MindHealth.Models
{
    public class Support : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
