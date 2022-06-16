using Microsoft.AspNetCore.Mvc;

namespace MindHealth.Models
{
    public class Notification : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
