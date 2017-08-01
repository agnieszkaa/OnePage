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
            var items = db.Kontakty;
            var list = new List<ContactDb>();
            foreach(var item in )
            {
                var dbcontact = new ContactDb()
                {
                    Name = item.Name,
                    SetLastName(item.LastName
)
                };
                list.Add(dbcontact);
            }
            return View(list);
        }
        public ActionResult Editor (Kontakty newContact)
        {
            ViewBag.Message = "Add your name";
            KontaktyDatabase db = new KontaktyDatabase();


            var dane = db.Kontakty;


            return View("Editor", dane);
        }
    }
}