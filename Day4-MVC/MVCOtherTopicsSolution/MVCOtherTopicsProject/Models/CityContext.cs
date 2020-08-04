using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCOtherTopicsProject.Models
{
    public class CityContext : DbContext
    {
        public CityContext() : base("name=efSample")
        {

        }
        public DbSet<People> peoples { get; set; }
    }
}