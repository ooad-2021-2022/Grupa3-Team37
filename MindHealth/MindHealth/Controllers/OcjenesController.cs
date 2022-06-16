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
    public class OcjenesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OcjenesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ocjenes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Ocjene.Include(o => o.Korisnik);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Ocjenes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocjene = await _context.Ocjene
                .Include(o => o.Korisnik)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ocjene == null)
            {
                return NotFound();
            }

            return View(ocjene);
        }

        // GET: Ocjenes/Create
        public IActionResult Create()
        {
            ViewData["idKorisnika"] = new SelectList(_context.Korisnik, "Id", "Id");
            return View();
        }

        // POST: Ocjenes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ocjena,idKorisnika")] Ocjene ocjene)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ocjene);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["idKorisnika"] = new SelectList(_context.Korisnik, "Id", "Id", ocjene.idKorisnika);
            return View(ocjene);
        }

        // GET: Ocjenes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocjene = await _context.Ocjene.FindAsync(id);
            if (ocjene == null)
            {
                return NotFound();
            }
            ViewData["idKorisnika"] = new SelectList(_context.Korisnik, "Id", "Id", ocjene.idKorisnika);
            return View(ocjene);
        }

        // POST: Ocjenes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ocjena,idKorisnika")] Ocjene ocjene)
        {
            if (id != ocjene.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Ocjene.Remove(ocjene);
                    _context.Update(ocjene);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OcjeneExists(ocjene.ID))
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
            ViewData["idKorisnika"] = new SelectList(_context.Korisnik, "Id", "Id", ocjene.idKorisnika);
            return View(ocjene);
        }

        // GET: Ocjenes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ocjene = await _context.Ocjene
                .Include(o => o.Korisnik)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ocjene == null)
            {
                return NotFound();
            }

            return View(ocjene);
        }

        // POST: Ocjenes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ocjene = await _context.Ocjene.FindAsync(id);
            _context.Ocjene.Remove(ocjene);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OcjeneExists(int id)
        {
            return _context.Ocjene.Any(e => e.ID == id);
        }
    }
}
