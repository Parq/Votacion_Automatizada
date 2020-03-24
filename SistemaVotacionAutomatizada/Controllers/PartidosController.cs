using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaVotacionAutomatizada.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using SistemaVotacionAutomatizada.DTO;

namespace SistemaVotacionAutomatizada.Controllers
{
    [Authorize]
    public class PartidosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IMapper _mapper;


        public PartidosController(ApplicationDbContext context, IMapper mapper, IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
            this._mapper = mapper;
            _context = context;
        }

        // GET: Partidos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Partidos.ToListAsync());
        }

        // GET: Partidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partidos = await _context.Partidos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partidos == null)
            {
                return NotFound();
            }

            return View(partidos);
        }

        // GET: Partidos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Partidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PartidosDTO model)
        {
            var partido = new Partidos();
            if (ModelState.IsValid)
            {

                string uniqueName = null;
                if (model.Logo != null)
                {
                    var folderPath = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniqueName = Guid.NewGuid().ToString() + "_" + model.Logo.FileName;
                    var filePath = Path.Combine(folderPath, uniqueName);

                    if (filePath != null) model.Logo.CopyTo(new FileStream(filePath, mode: FileMode.Create));
                }


                partido = _mapper.Map<Partidos>(model);

                partido.Logo = uniqueName;

                _context.Add(partido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: Partidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partido = await _context.Partidos.FindAsync(id);
            if (partido == null)
            {
                return NotFound();
            }
            var partidoDto = _mapper.Map<PartidosDTO>(partido);
            return View(partidoDto);
        }

        // POST: Partidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PartidosDTO dto)
        {
            if (id != dto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var partido = await _context.Partidos.FirstOrDefaultAsync(d => d.Id == dto.Id);

                    string uniqueName = null;
                    if (dto.Logo != null)
                    {
                        var folderPath = Path.Combine(hostingEnvironment.WebRootPath, "images");
                        uniqueName = Guid.NewGuid().ToString() + "_" + dto.Logo.FileName;
                        var filePath = Path.Combine(folderPath, uniqueName);

                       
                        if (!string.IsNullOrEmpty(partido.Logo))
                        { 
                            var filePathDelete = Path.Combine(folderPath, partido.Logo);

                            if (System.IO.File.Exists(filePathDelete))
                            {
                                var fileInfo = new System.IO.FileInfo(filePathDelete);
                                fileInfo.Delete();
                            }
                        }

                        if (filePath != null) dto.Logo.CopyTo(new FileStream(filePath, mode: FileMode.Create));
                    }


                    partido.Nombre = dto.Nombre;
                    partido.Descripcion = dto.Descripcion;
                    partido.Estado = dto.Estado;
                    
                    partido.Logo = uniqueName;

                    _context.Update(partido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PartidosExists(dto.Id))
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
            return View(dto);
        }

        // GET: Partidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partidos = await _context.Partidos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (partidos == null)
            {
                return NotFound();
            }

            return View(partidos);
        }

        // POST: Partidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var partidos = await _context.Partidos.FindAsync(id);
            _context.Partidos.Remove(partidos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PartidosExists(int id)
        {
            return _context.Partidos.Any(e => e.Id == id);
        }
    }
}
