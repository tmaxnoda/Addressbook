using Addressbook.Web.Models;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Addressbook.Web.Controllers
{
    public class AccountController : Controller
    {
        public IAuthenticationManager  Authentication => HttpContext.GetOwinContext().Authentication;
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            //sign user in
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier,"1"),
                new Claim(ClaimTypes.Email, model.Email),
                new Claim(ClaimTypes.Role,"Admin")
            };

            var identity = new ClaimsIdentity(claims);

            
            Authentication.SignIn(identity);
            return View(model);
        }
    }
}