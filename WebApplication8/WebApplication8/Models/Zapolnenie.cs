using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class Zapolnenie
    {
        public int ZapolnenieId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string addres { get; set; }
        public string sex { get; set; }
        public string idnumber { get; set; }
        public int ZapolnId { get; set; }
    }
}