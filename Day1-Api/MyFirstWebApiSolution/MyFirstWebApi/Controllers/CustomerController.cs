using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstWebApi.Controllers
{
    public class CustomerController : ApiController
    {

        static List<string> names = new List<string>() { "Ramu","Bimu","Somu"};
        [HttpGet]
        public List<string> GetAllCustomers()
        {
            
            return names;
        }

        [HttpGet]
        public string GetCustomer(int id)
        {
            return names[id];
        }

        [HttpPost]
        public void AddCustomer([FromBody]string name)
        {
            names.Add(name);
        }
    }
}
