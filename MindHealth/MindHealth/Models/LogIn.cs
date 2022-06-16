using Microsoft.AspNetCore.Mvc;

namespace MindHealth.Models
{
    public class LogIn : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
