using Microsoft.AspNetCore.Mvc;

namespace MindHealth.Models
{
    public class Therapists : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
