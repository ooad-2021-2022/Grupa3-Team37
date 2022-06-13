using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MindHealth.Data;
using MindHealth.Models;

namespace MindHealth.Controllers
{
    public class UpitnikController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UpitnikController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Upitnik
        public async Task<IActionResult> Index()
        { var applicationDbContext = _context.Korisnik.FirstOrDefault(u => u.username == User.Identity.Name);
            var app = _context.Upitnik.FirstOrDefault(u => u.idKorisnika == applicationDbContext.Id);
            var a = _context.OdgovoriNaPitanje.Include(o => o.upitnik);
            return View(await a.ToListAsync());
        }
       
        /* public async Task<IActionResult> Index()
         {
             if (ModelState.IsValid)
             {
                 _context.Add(termin);
                 await _context.SaveChangesAsync();
                 return RedirectToAction(nameof(Index));
             }
             return View();
         }*/
    } 
      
}
