using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCOtherTopicsProject.Models;

namespace MVCOtherTopicsProject.Controllers
{
    public class CityController : Controller
    {
        CityContext city = new CityContext();
        // GET: City
        public ActionResult Index()
        {
            return View(city.peoples);
        }

        public ActionResult Create()
        {
            People person = new People();
            return View(person);
        }

        [HttpPost]
        public ActionResult Create(People people)
        {
            city.peoples.Add(people);
            city.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}