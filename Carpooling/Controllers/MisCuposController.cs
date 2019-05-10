using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Carpooling.Controllers
{
    public class MisCuposController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}