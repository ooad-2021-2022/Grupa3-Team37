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
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.OdgovoriNaPitanje.Include(o => o.Upitnik);
            return View(await applicationDbContext.ToListAsync());
        }
        public async Task<IActionResult> CalculateDiagnoses()
        {
            var applicationDbContext = _context.OdgovoriNaPitanje.Include(o => o.Upitnik);
            int brojPitanja=0;
            int brojPozitivnih = 0;
            foreach(OdgovoriNaPitanje i in applicationDbContext)
            {
                brojPitanja++;
                if (i.odgovoreno == 1)
                {
                    brojPozitivnih++;
                }
            }
            double procenat =( (((double)brojPozitivnih) / ((double)brojPitanja)))*(double)100;
            return View(procenat);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odgovoriNaPitanje = await _context.OdgovoriNaPitanje.FindAsync(id);
            if (odgovoriNaPitanje == null)
            {
                return NotFound();
            }
            ViewData["upitnikID"] = new SelectList(_context.Upitnik, "Id", "Id", odgovoriNaPitanje.upitnikID);
            return View(odgovoriNaPitanje);
        }

        // POST: OdgovoriNaPitanjes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,upitnikID,odgovoreno,tekstPitanja")] OdgovoriNaPitanje odgovoriNaPitanje)
        {
            if (id != odgovoriNaPitanje.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(odgovoriNaPitanje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OdgovoriNaPitanjeExists(odgovoriNaPitanje.Id))
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
            ViewData["upitnikID"] = new SelectList(_context.Upitnik, "Id", "Id", odgovoriNaPitanje.upitnikID);
            return View(odgovoriNaPitanje);
        }
        private bool OdgovoriNaPitanjeExists(int id)
        {
            return _context.OdgovoriNaPitanje.Any(e => e.Id == id);
        }
    }
    }
