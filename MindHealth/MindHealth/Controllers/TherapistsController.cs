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
            var x = await _context.Korisnik.ToListAsync();
            var x1 = await _context.Users.ToListAsync();
            List<Korisnik> ter=new List<Korisnik>();
            if (x1.Count > 0 && x.Count > 0)
                foreach (var i in x)
                {
                    if (x1.Any(a => a.UserName == i.email))
                    {
                        var y = x1.First(a => a.UserName == i.email);
                        if (y != null)
                        {
                            if (_context.UserRoles.Any(a => a.UserId == y.Id && a.RoleId == "1"))
                            {
                                var rol = _context.UserRoles.First(a => a.UserId == y.Id && a.RoleId == "1");
                                if (rol != null)
                                {
                                    ter.Add(i);
                                }
                            }
                        }
                    }
                }
            return View(ter);
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
      public  async Task<IActionResult> CheckAvailability(int id,DateTime datum,Termin termin)
        {
            var terminiTerapeuta= await _context.Termin.FirstOrDefaultAsync(m => m.idPsiholog ==id&& m.vrijemeOdrzavanja == datum);
            if (terminiTerapeuta == null)
            {
                return View(termin);
            }
            return NotFound();

        }
        
        [HttpPost, ActionName("MakeAnAppointment")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MakeAnAppointment([Bind("idTermina,cijenaTermina,usernameKorisnika,usernamePsihoterapeuta,opisTermina,idKorisnika,vrijemeOdrzavanja,idPsiholog")] Termin termin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(termin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(termin);
        }

        [Authorize(Roles ="Korisnik, PremiumKorisnik")]
       public async Task<IActionResult> MakeAnAppointment(int id)
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
            termin.vrijemeOdrzavanja = DateTime.Today;
            termin.idPsiholog = id;
            termin.idKorisnika = 4;
            if (korisnik == null)
            {
                return NotFound();
            }
            return View(termin);
           

        }

    }
}
