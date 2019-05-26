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
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        //
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        //public async Task<IActionResult> Index()
        //{
        //    string currentUserName = User.Identity.Name;
        //    Usuario currentUser = _context.Users.FirstOrDefault(x => x.UserName == currentUserName);

        //    return View(await _context.Users.ToListAsync());
        //}
        //public async Task<IActionResult> Edit(string id)
        //{
            

        //    var vehiculo = await _context.Users.FindAsync(id);
        //    if (vehiculo == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(vehiculo);
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(string id, [Bind("Nombre,Apellido,Nick,Area,PhoneNumber")] Usuario usuario)
        //{
        //    if (id != usuario.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(usuario);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!UsuarioExists(usuario.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(usuario);
        //}


        private bool UsuarioExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Profile()
        {
            return View(await _context.Viaje.ToListAsync());
        }
    }
}