using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Carpooling.Controllers
{
    [Route("auth")]
    public class AuthController : Controller
    {
        [Route("singin")]
        public IActionResult SingIn()
        {
            return Challenge(new AuthenticationProperties { RedirectUri = "/" });
        }
    }
}