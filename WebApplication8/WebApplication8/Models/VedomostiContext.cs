using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication8.Models
{
    public class VedomostiContext : DbContext
    {
        public VedomostiContext() : base("name=VedomostiContext") { }
        public DbSet<Vedomosti> Vedomostis { get; set; }
        public DbSet<Zapolnenie> Zapolnenies { get; set; }


    }
}