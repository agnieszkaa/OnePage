using BaseFirst.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            Kontakty db = new Kontakty();
            var items = db.Kontakty;
            var list = new List<ContactDb>();
            
                
                
            
            return View(list);
        }

        private object SetLastName(object lastName)
        {
            throw new NotImplementedException();
        }

        public ActionResult Editor(ContactDb newContact)
        {
            ViewBag.Message = "Add your name";
            KontaktyDatabase db = new KontaktyDatabase();


            var dane = db.Kontakty;


            return View("Editor", dane);
        }
    }
}