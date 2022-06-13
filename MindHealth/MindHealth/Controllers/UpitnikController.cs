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
        { //var applicationDbContext = _context.Korisnik.FirstOrDefault(u => u.username == User.Identity.Name);
           // var app = _context.Upitnik.FirstOrDefault(u => u.idKorisnika == applicationDbContext.Id);
            var a = _context.OdgovoriNaPitanje.Include(o => o.upitnik);
            List<String> l=new List<String>();
            l.Add("Yes");
            l.Add("No");
            return View(a);
        }
       
        public async Task<IActionResult> AddTheAnswer([Bind("Id,upitnikId, odgovoreno, tekstPitanja")] OdgovoriNaPitanje odgovor)
         {
            if (ModelState.IsValid)
            {
                try
                {

                   // _context.Ocjene.Remove(o);
                    _context.Update(odgovor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OdgovorExists(odgovor.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }
        private bool OdgovorExists(int id)
        {
            return _context.Ocjene.Any(e => e.ID == id);
        }
    } 
      
}
