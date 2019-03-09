using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Carpooling.Controllers
{
    public class PassengerController : Controller
    {
        public IActionResult PassengerLobby()
        {


            return View();
        }
    }
}