using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCOtherTopicsProject.Models;

namespace MVCOtherTopicsProject.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> customers = new List<Customer>();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            customers.Add(new Customer(101, "Ramu", 22));
            customers.Add(new Customer(102, "Somu", 31));
            customers.Add(new Customer(101, "Bimu", 29));
            customers[0][0] = "C#";
            customers[0][1] = "SQL";
            customers[1][0] = "Java";
            customers[1][1] = "MySQL";
            customers[1][2] = "Oracle";
            customers[2][0] = "C";
            return View(customers);
        }
        [ChildActionOnly]
        public PartialViewResult PartData(string name)
        {
            Customer customer = new Customer();
            customer = customers.Find((c) => c.Name == name);
            return PartialView("_PartView",customer);
        }
    }
}