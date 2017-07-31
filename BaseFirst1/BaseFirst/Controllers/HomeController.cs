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
    }
}