using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Carpooling.Controllers
{
    public class DriverController : Controller
    {
        public IActionResult DriverLobby()
        {
            return View();
        }
        public IActionResult Reservation()
        {


            return View();
        }
    }
}