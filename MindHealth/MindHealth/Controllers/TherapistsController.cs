using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MindHealth.Data;
using MindHealth.Models;

namespace MindHealth.Controllers
{

    public class TherapistsController : Controller
    {
        private readonly ApplicationDbContext _context;
       
        public TherapistsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Therapists
        public async Task<IActionResult> Index()
        {
            return View(await _context.Korisnik.ToListAsync());
        }

        // GET: Therapists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnik = await _context.Korisnik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (korisnik == null)
            {
                return NotFound();
            }

            return View(korisnik);
        }
        [Authorize(Roles = "Korisnik, PremiumKorisnik")]
      public  async Task<IActionResult> CheckAvailability(int id,DateTime datum)
        {
            var terminiTerapeuta= await _context.Termin.FirstOrDefaultAsync(m => m.idPsiholog ==id&& m.vrijemeOdrzavanja == datum);
            if (terminiTerapeuta == null)
            {
                return View();
            }
            return NotFound();

        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckAvailability(Termin termin) {
            
            if (ModelState.IsValid)
            {
                _context.Add(termin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        [Authorize(Roles ="Korisnik, PremiumKorisnik")]
       public async Task<IActionResult> MakeAnAppointment(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var korisnik = await _context.Korisnik .FirstOrDefaultAsync(m => m.Id == id);
            var termin = new Termin();
            termin.cijenaTermina = 25;
            termin.usernameKorisnika = User.Identity.Name;
            termin.usernamePsihoterapeuta = korisnik.username;
            termin.opisTermina = "";
            termin.idPsiholog = korisnik.Id;
            if (korisnik == null)
            {
                return NotFound();
            }
            return View(termin);
           

        }

    }
}
