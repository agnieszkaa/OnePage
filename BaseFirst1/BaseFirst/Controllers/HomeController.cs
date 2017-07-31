using BaseFirst.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        
        public ActionResult Index()
        {
            DataBaseFirstEntities db = new DataBaseFirstEntities();
            var dane = db.Kontakty;
            return View(dane);
        }
        public ActionResult addName(Kontakty newContact)
        {
            ViewBag.Message = "Add your name";
            DataBaseFirstEntities db = new DataBaseFirstEntities();
            

            db.Kontakty.Add(newContact);
            db.SaveChanges();
            return View("Editor");
        }
    }
}