using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFExampleProject.Controllers
{
    public class MovieController : Controller
    {
        dbMovieShopEntities shopEntities = new dbMovieShopEntities();
        // GET: Movie
        public ActionResult Index()
        {
            return View(shopEntities.tblMovies);
        }
    }
}