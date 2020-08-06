using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using FormsAuthenticationProject.Models;

namespace FormsAuthenticationProject.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        // GET: Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Login(User user)
        {
            if(user.Password=="1234")
            {
                FormsAuthentication.SetAuthCookie(user.Username, false);
                return RedirectToAction("Home");
            }
            ViewBag.ErrorMessage = "Invalid Username or Password..";
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }


    }
}