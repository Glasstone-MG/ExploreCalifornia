using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Configuration;

namespace ExploreCalifornia.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base(ConfigurationManager.ConnectionStrings["ECConn"].ConnectionString )
        {

        }

        public DbSet<Tour> Tours { get; set; }
    }
}