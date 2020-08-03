using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFExampleProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        dbMovieShopEntities entities = new dbMovieShopEntities();
        public ActionResult UserLogin()
        {
            UserData myUser = new UserData();
            if (TempData["username"] != null)
                myUser.username = TempData["username"].ToString();
            return View(myUser);
        }
        [HttpPost]
        public ActionResult UserLogin(UserData user)
        {
            if(ModelState.IsValid)
            {
                //select count(*) from userData where username = @username and password = @pass
                int myUser = entities.UserDatas.Where(u => u.username == user.username && u.password == user.password).Count();
                if (myUser == 1)
                    ViewBag.message = "Welcome.. Your login is success!!!";
                else
                    ViewBag.message = "Invalid Username or password";
            }
            return View();
        }
        public ActionResult UserRegister()
        {
            UserData myUser = new UserData();
            return View(myUser);
        }
        [HttpPost]
        public ActionResult UserRegister(FormCollection collection)
        {
            UserData user = new UserData();
            if(collection.Get("password").Equals(collection.Get("RePass")))
            {
                user.username = collection.Get("username");
                user.password = collection.Get("password");
                entities.UserDatas.Add(user);
                entities.SaveChanges();
                TempData.Add("username", user.username);
                return RedirectToAction("UserLogin");

            }
            return View();
        }

    }
}