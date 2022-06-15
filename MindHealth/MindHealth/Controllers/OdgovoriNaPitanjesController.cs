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
    public class OdgovoriNaPitanjesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OdgovoriNaPitanjesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: OdgovoriNaPitanjes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.OdgovoriNaPitanje.Include(o => o.Upitnik);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: OdgovoriNaPitanjes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odgovoriNaPitanje = await _context.OdgovoriNaPitanje
                .Include(o => o.Upitnik)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (odgovoriNaPitanje == null)
            {
                return NotFound();
            }

            return View(odgovoriNaPitanje);
        }

        // GET: OdgovoriNaPitanjes/Create
        public IActionResult Create()
        {
            ViewData["upitnikID"] = new SelectList(_context.Upitnik, "Id", "Id");
            return View();
        }

        // POST: OdgovoriNaPitanjes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,upitnikID,odgovoreno,tekstPitanja")] OdgovoriNaPitanje odgovoriNaPitanje)
        {
            if (ModelState.IsValid)
            {
                _context.Add(odgovoriNaPitanje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["upitnikID"] = new SelectList(_context.Upitnik, "Id", "Id", odgovoriNaPitanje.upitnikID);
            return View(odgovoriNaPitanje);
        }

        // GET: OdgovoriNaPitanjes/Edit/5
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

        // GET: OdgovoriNaPitanjes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odgovoriNaPitanje = await _context.OdgovoriNaPitanje
                .Include(o => o.Upitnik)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (odgovoriNaPitanje == null)
            {
                return NotFound();
            }

            return View(odgovoriNaPitanje);
        }

        // POST: OdgovoriNaPitanjes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var odgovoriNaPitanje = await _context.OdgovoriNaPitanje.FindAsync(id);
            _context.OdgovoriNaPitanje.Remove(odgovoriNaPitanje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OdgovoriNaPitanjeExists(int id)
        {
            return _context.OdgovoriNaPitanje.Any(e => e.Id == id);
        }
    }
}
