using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication8.Models
{
    public class VedomostiDbInitializer : DropCreateDatabaseIfModelChanges<VedomostiContext>
    {
        protected override void Seed(VedomostiContext db)
        {
            db.Vedomostis.Add(new Vedomosti { name = "tegagagagst", surname = "test", addres = "test", sex ="male", idnumber = "23536324" });
            base.Seed(db);
        }
    }
}