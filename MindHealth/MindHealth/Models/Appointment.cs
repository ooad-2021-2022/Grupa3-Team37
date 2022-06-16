using Microsoft.AspNetCore.Mvc;

namespace MindHealth.Models
{
    public class Appointment : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
