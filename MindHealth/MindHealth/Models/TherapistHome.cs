using Microsoft.AspNetCore.Mvc;

namespace MindHealth.Models
{
    public class TherapistHome : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
