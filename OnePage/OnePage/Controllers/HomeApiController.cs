using OnePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace OnePage.Controllers
{
    public class HomeApiController : Controller
    {
        

        

        public JsonResult ShowContacts(string name, string lastName)
        {
            KontaktyDatabase db = new KontaktyDatabase();
            var items = db.Contacts;
            var list = items.ToList();
            
            
            //var list = new List<string>() { "MAMA", "TATA", "JA" };
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Add(string name, string lastName)
        {
            KontaktyDatabase db = new KontaktyDatabase();
            var dane = db.Contacts;
            return Json(dane);
        }
        public JsonResult Add(Contact newContact, string name, string lastName)
        {
            var contact = (string.Format("name:{0}, lastName:{1}", name, lastName));
           
            KontaktyDatabase db = new KontaktyDatabase();
            db.Contacts.Add(newContact);
            db.SaveChanges();


            return Json(contact);
        }


        public JsonResult Dalete(string id)
        {

            int idToDelete = int.Parse(id);

             return Json(idToDelete);
        }
        public JsonResult Dalete(Contact contactDelete, string id)
        {

            KontaktyDatabase db = new KontaktyDatabase();
            int Id = Int32.Parse(id);
            Contact contactFind = db.Contacts.Find(Id);
            db.Contacts.Remove(contactFind);
            db.SaveChanges();
            return Json(Id);

        }

        public void ParEditor(Contact contactPar)
        {

            System.Console.WriteLine(string.Format("Name: {0}, LastName: {1}", contactPar.name, contactPar.lastName));

        }
    }
}
