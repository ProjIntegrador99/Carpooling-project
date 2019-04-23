using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Carpooling.Data;
using Carpooling.Models;

namespace Carpooling.Controllers
{
    public class TribusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TribusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Tribus
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tribu.ToListAsync());
        }

        // GET: Tribus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tribu = await _context.Tribu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tribu == null)
            {
                return NotFound();
            }

            return View(tribu);
        }

        // GET: Tribus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tribus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,GeneroMusical")] Tribu tribu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tribu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tribu);
        }

        // GET: Tribus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tribu = await _context.Tribu.FindAsync(id);
            if (tribu == null)
            {
                return NotFound();
            }
            return View(tribu);
        }

        // POST: Tribus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,GeneroMusical")] Tribu tribu)
        {
            if (id != tribu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tribu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TribuExists(tribu.Id))
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
            return View(tribu);
        }

        // GET: Tribus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tribu = await _context.Tribu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tribu == null)
            {
                return NotFound();
            }

            return View(tribu);
        }

        // POST: Tribus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tribu = await _context.Tribu.FindAsync(id);
            _context.Tribu.Remove(tribu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TribuExists(int id)
        {
            return _context.Tribu.Any(e => e.Id == id);
        }
    }
}
