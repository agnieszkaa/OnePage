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
            KontaktyDatabase db = new KontaktyDatabase();
            var items = db.Contacts;
            var list = items.ToList();
             
            return View(list);
        }

        private object SetLastName(object lastName)
        {
            throw new NotImplementedException();
        }

        public ActionResult Editor(Contact newContact)
        {
            ViewBag.Message = "Add your name";
            KontaktyDatabase db = new KontaktyDatabase();


            var dane = db.Contacts;


            return View( dane);
        }
    }
}