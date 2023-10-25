using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JorgeMoncayo_Examen1P.Data;
using JorgeMoncayo_Examen1P.Models;

namespace JorgeMoncayo_Examen1P.Controllers
{
    public class JorgeMoncayo_tablaController : Controller
    {
        private readonly JorgeMoncayo_Examen1PContext _context;

        public JorgeMoncayo_tablaController(JorgeMoncayo_Examen1PContext context)
        {
            _context = context;
        }

        // GET: JorgeMoncayo_tabla
        public async Task<IActionResult> Index()
        {
              return _context.JorgeMoncayo_tabla != null ? 
                          View(await _context.JorgeMoncayo_tabla.ToListAsync()) :
                          Problem("Entity set 'JorgeMoncayo_Examen1PContext.JorgeMoncayo_tabla'  is null.");
        }

        // GET: JorgeMoncayo_tabla/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.JorgeMoncayo_tabla == null)
            {
                return NotFound();
            }

            var jorgeMoncayo_tabla = await _context.JorgeMoncayo_tabla
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jorgeMoncayo_tabla == null)
            {
                return NotFound();
            }

            return View(jorgeMoncayo_tabla);
        }

        // GET: JorgeMoncayo_tabla/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JorgeMoncayo_tabla/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreJuego,Ps4,Ps5,Precio,PrecioDate")] JorgeMoncayo_tabla jorgeMoncayo_tabla)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jorgeMoncayo_tabla);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jorgeMoncayo_tabla);
        }

        // GET: JorgeMoncayo_tabla/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.JorgeMoncayo_tabla == null)
            {
                return NotFound();
            }

            var jorgeMoncayo_tabla = await _context.JorgeMoncayo_tabla.FindAsync(id);
            if (jorgeMoncayo_tabla == null)
            {
                return NotFound();
            }
            return View(jorgeMoncayo_tabla);
        }

        // POST: JorgeMoncayo_tabla/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreJuego,Ps4,Ps5,Precio,PrecioDate")] JorgeMoncayo_tabla jorgeMoncayo_tabla)
        {
            if (id != jorgeMoncayo_tabla.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jorgeMoncayo_tabla);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JorgeMoncayo_tablaExists(jorgeMoncayo_tabla.Id))
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
            return View(jorgeMoncayo_tabla);
        }

        // GET: JorgeMoncayo_tabla/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.JorgeMoncayo_tabla == null)
            {
                return NotFound();
            }

            var jorgeMoncayo_tabla = await _context.JorgeMoncayo_tabla
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jorgeMoncayo_tabla == null)
            {
                return NotFound();
            }

            return View(jorgeMoncayo_tabla);
        }

        // POST: JorgeMoncayo_tabla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.JorgeMoncayo_tabla == null)
            {
                return Problem("Entity set 'JorgeMoncayo_Examen1PContext.JorgeMoncayo_tabla'  is null.");
            }
            var jorgeMoncayo_tabla = await _context.JorgeMoncayo_tabla.FindAsync(id);
            if (jorgeMoncayo_tabla != null)
            {
                _context.JorgeMoncayo_tabla.Remove(jorgeMoncayo_tabla);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JorgeMoncayo_tablaExists(int id)
        {
          return (_context.JorgeMoncayo_tabla?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
