using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpooling.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Carpooling.Controllers
{
    public class MisCuposController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MisCuposController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Viaje.ToListAsync());
        }
    }
}