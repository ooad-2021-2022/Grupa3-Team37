using Microsoft.AspNetCore.Mvc;

namespace MindHealth.Models
{
    public class About : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
