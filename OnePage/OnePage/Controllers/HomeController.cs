using OnePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnePage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ShowContacts(string name, string lastName)
        {
            KontaktyDatabase db = new KontaktyDatabase();
            var items = db.Contacts;
            var list = items.ToList();

            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Add(Contact newContact, string name, string lastName)
        {
            var contact = (string.Format("name:{0}, lastName:{1}", name, lastName));
            var id = Guid.NewGuid().ToString();
            newContact.id = id;
            KontaktyDatabase db = new KontaktyDatabase();
            db.Contacts.Add(newContact);
            db.SaveChanges();


            return RedirectToAction("Index");
        }
        //public ActionResult Add()
        //{
        //    return RedirectToAction("Index");
        //}
        
        public ActionResult Delete(string id)
        {
            KontaktyDatabase db = new KontaktyDatabase();
            //int Id = Int32.Parse(id);
            Contact contactFind = db.Contacts.Find(id);
            db.Contacts.Remove(contactFind);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}