﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarpoolingV2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            ViewData["Correo"] = User.Identity;
           // ViewData["Telefono"] = User.Identity.
            return View();
        }
    }
}