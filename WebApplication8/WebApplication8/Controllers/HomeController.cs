using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication8.Models;
  
namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        VedomostiContext db = new VedomostiContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Zapolnenie> Zapolnenies = db.Zapolnenies.ToList();
            // передаем все полученный объекты в динамическое свойство Books в ViewBag
           // ViewBag.Zapolnenie = Zapolnenies;
            // возвращаем представление
            return View(Zapolnenies);
        }
        [HttpGet]
        public ActionResult zapolnit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult zapolnit(Zapolnenie zapolnenie)
        {
            db.Zapolnenies.Add(zapolnenie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditZapoln(int id)
        {
            var det = db.Zapolnenies.Find(id);
            if(det==null)
            {
                return HttpNotFound();
            }
            return View(det);
        }
        [HttpPost]
        public ActionResult EditZapoln(Zapolnenie zp)
        {
            db.Entry(zp).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeleteZp(int id)
        {
            var det = db.Zapolnenies.Find(id);
            if (det == null)
            {
                return HttpNotFound();
            }
            return View(det);
        }
        [HttpPost, ActionName("DeleteZp")]
        public ActionResult ConfirmDeleteZp(int id)
        {
            var det = db.Zapolnenies.Find(id);

            db.Zapolnenies.Remove(det);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //    [HttpGet]
        //    public ActionResult Edit(int id)
        //    {
        //Zapolnenie zapolnenies = db.Zapolnenies.Find(id);
        //if (zapolnenies != null)
        //{
        //    return PartialView("Edit", zapolnenies);
        //}
        //return View("Index");
        //    }
        //    [HttpPost]
        //    public ActionResult Edit(Zapolnenie zapolnenie)
        //    {

        //    }
        public ActionResult AboutMe() => View();
        
    }
}