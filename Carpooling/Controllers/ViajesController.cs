using System;
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
    public class ViajesController : Controller
    {
        private readonly ApplicationDbContext _context;
       

        public ViajesController(ApplicationDbContext context)
        {
            _context = context;
           
        }

        // GET: Viajes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Viaje.ToListAsync());
        }

        // GET: Viajes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viaje = await _context.Viaje
                .FirstOrDefaultAsync(m => m.Id == id);
            if (viaje == null)
            {
                return NotFound();
            }

            return View(viaje);
        }

        // GET: Viajes/Create
        public IActionResult Create()
        {
            ViewData["conductor"] = User.Identity.Name;
            return View();
        }

        // POST: Viajes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion,Hora,TipoViaje,Estado,Cupos,NombreConductor")] Viaje viaje)
        {
            //ffgggg
            string currentUserName = User.Identity.Name;
            DateTime tiempo = new DateTime();
            Usuario currentUser = _context.Users.FirstOrDefault(x => x.UserName == currentUserName);
            
                if (ModelState.IsValid)
                {

                    if (_context.Viaje.Where(j => j.Descripcion.Equals(viaje.Descripcion) && j.NombreConductor.Equals(viaje.NombreConductor) && j.Hora.Equals(viaje.Hora)).Any())
                    {

                    
                        //viaje.cambiarCupos();
                        //_context.Update(viaje);
                        //await _context.SaveChangesAsync();
                        viaje.cambiarTipoViaje(false);
                        viaje.cambiarEmailotro(currentUser.Email);
                        _context.Add(viaje);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));

                    }
                    else
                    {

                    if (_context.Vehiculo.Count(x => x.UsuarioId.Equals(currentUser.Id)) != 0 && viaje.Hora.Date > tiempo.Date)
                    {

                        viaje.cambiarTipoViaje(true);
                        _context.Add(viaje);
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));

                    }


                }
            }

           


            return View(viaje);
        }

     

        public async Task<IActionResult> Solicitar(int? id)
        {
            ViewData["conductor"] = User.Identity.Name;
            if (id == null)
            {
                return NotFound();
            }

            var viaje = await _context.Viaje
                .FirstOrDefaultAsync(m => m.Id == id);



            if (viaje == null)
            {
                return NotFound();
            }

            return View(viaje);
        }

        // GET: Viajes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["conductor"] = User.Identity.Name;
            if (id == null)
            {
                return NotFound();
            }

            var viaje = await _context.Viaje.FindAsync(id);
            if (viaje == null)
            {
                return NotFound();
            }
            return View(viaje);
        }

        // POST: Viajes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion,Hora,TipoViaje,Estado,Cupos,NombreConductor")] Viaje viaje)
        {
            if (id != viaje.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(viaje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ViajeExists(viaje.Id))
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
            return View(viaje);
        }

        // GET: Viajes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viaje = await _context.Viaje
                .FirstOrDefaultAsync(m => m.Id == id);
            if (viaje == null)
            {
                return NotFound();
            }

            return View(viaje);
        }

        // POST: Viajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var viaje = await _context.Viaje.FindAsync(id);
            _context.Viaje.Remove(viaje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ViajeExists(int id)
        {
            return _context.Viaje.Any(e => e.Id == id);
        }
    }
}
