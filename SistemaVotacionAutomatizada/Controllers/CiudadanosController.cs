using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaVotacionAutomatizada.Models;

namespace SistemaVotacionAutomatizada.Controllers
{
    public class CiudadanosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CiudadanosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ciudadanos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ciudadanos.ToListAsync());
        }

        // GET: Ciudadanos/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudadanos = await _context.Ciudadanos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ciudadanos == null)
            {
                return NotFound();
            }

            return View(ciudadanos);
        }

        // GET: Ciudadanos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ciudadanos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Apellido,Email,Estado")] Ciudadanos ciudadanos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ciudadanos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ciudadanos);
        }

        // GET: Ciudadanos/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudadanos = await _context.Ciudadanos.FindAsync(id);
            if (ciudadanos == null)
            {
                return NotFound();
            }
            return View(ciudadanos);
        }

        // POST: Ciudadanos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Nombre,Apellido,Email,Estado")] Ciudadanos ciudadanos)
        {
            if (id != ciudadanos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ciudadanos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CiudadanosExists(ciudadanos.Id))
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
            return View(ciudadanos);
        }

        // GET: Ciudadanos/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciudadanos = await _context.Ciudadanos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ciudadanos == null)
            {
                return NotFound();
            }

            return View(ciudadanos);
        }

        // POST: Ciudadanos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var ciudadanos = await _context.Ciudadanos.FindAsync(id);
            _context.Ciudadanos.Remove(ciudadanos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CiudadanosExists(string id)
        {
            return _context.Ciudadanos.Any(e => e.Id == id);
        }
    }
}
