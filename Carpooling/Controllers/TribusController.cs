﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Carpooling.Data;
using Carpooling.Models;
using Microsoft.AspNetCore.Identity;

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
             //string currentUserName = User.Identity.Name;
            //Usuario currentUser = _context.Users.FirstOrDefault(x => x.UserName == currentUserName);
            //return View(await _context.Tribu.ToListAsync());
            //return View(await _context.Tribu.Select(m => new { estaContenido = _context.UsuariosTribus.Any(j => j.UsuarioId.Equals(currentUser.Id)), t = m }).Where(k => k.estaContenido).Select(p => p.t).ToListAsync());
            //var m = _context.UsuariosTribus.Where(u => u.UsuarioId.Equals(currentUser.Id)).Select(k => k.TribuId).ToList();
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
                string currentUserName = User.Identity.Name;
                Usuario currentUser = _context.Users.FirstOrDefault(x => x.UserName == currentUserName);
                UsuarioTribu m = new UsuarioTribu()
                {
                    UsuarioId = currentUser.Id,
                    TribuId = tribu.Id,
                    Tribus = tribu,
                    Usuarios = currentUser
                };
                _context.UsuariosTribus.Add(m);     
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

       
        public IActionResult Join(int id)
        {
            string currentUserName = User.Identity.Name;
            Usuario currentUser = _context.Users.FirstOrDefault(x => x.UserName == currentUserName);

            if (_context.UsuariosTribus.Any(x => x.UsuarioId.Equals(currentUser.Id) && x.TribuId == id))
            {
                return View("Index", _context.Tribu);
            }
            else
            {
                _context.UsuariosTribus.Add(new UsuarioTribu{
                    TribuId = id,
                    UsuarioId = currentUser.Id
                });
                _context.SaveChanges();
                return View("Index", _context.Tribu);
            }
        }
    }
}
