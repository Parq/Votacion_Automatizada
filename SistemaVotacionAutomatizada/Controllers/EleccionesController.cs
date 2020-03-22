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
    public class EleccionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EleccionesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Elecciones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Elecciones.ToListAsync());
        }

        // GET: Elecciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elecciones = await _context.Elecciones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (elecciones == null)
            {
                return NotFound();
            }

            return View(elecciones);
        }

        // GET: Elecciones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Elecciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Fecha,Estado")] Elecciones elecciones)
        {
            if (ModelState.IsValid)
            {
                _context.Add(elecciones);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(elecciones);
        }

        // GET: Elecciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elecciones = await _context.Elecciones.FindAsync(id);
            if (elecciones == null)
            {
                return NotFound();
            }
            return View(elecciones);
        }

        // POST: Elecciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Fecha,Estado")] Elecciones elecciones)
        {
            if (id != elecciones.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(elecciones);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EleccionesExists(elecciones.Id))
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
            return View(elecciones);
        }

        // GET: Elecciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var elecciones = await _context.Elecciones
                .FirstOrDefaultAsync(m => m.Id == id);
            if (elecciones == null)
            {
                return NotFound();
            }

            return View(elecciones);
        }

        // POST: Elecciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var elecciones = await _context.Elecciones.FindAsync(id);
            _context.Elecciones.Remove(elecciones);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EleccionesExists(int id)
        {
            return _context.Elecciones.Any(e => e.Id == id);
        }
    }
}
