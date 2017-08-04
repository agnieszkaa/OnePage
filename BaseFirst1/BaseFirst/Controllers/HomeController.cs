using BaseFirst.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseFirst.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            KontaktyDatabase db = new KontaktyDatabase();
            var items = db.Contacts;
            var list = items.ToList();
             
            return View(list);
        }
        [HttpGet]
        public ActionResult Editor(string NAme, string LastNAme)
        {
            KontaktyDatabase db = new KontaktyDatabase();
            var dane = db.Contacts;
            return View(dane);
        }
        public ActionResult Editor(Contact newContact, string NAme, string LastNAme)
        {
            var contact = (string.Format("NAme:{0}, LastNAme:{1}", NAme,LastNAme));
            ViewBag.Message = "Add your name";
            KontaktyDatabase db = new KontaktyDatabase();
            db.Contacts.Add(newContact);
            db.SaveChanges();

           
            return RedirectToAction("Index");
        }
        
        
       [HttpGet]
        public ActionResult Dalete(string id)
        {
            
            int idToDelete = int.Parse(id);
            
            return View(idToDelete);

        }
        [HttpPost]
        public  ActionResult Dalete(Contact contactDelete, string id) 
        {
            
            KontaktyDatabase db = new KontaktyDatabase();
            int Id = Int32.Parse(id);
            Contact contactFind = db.Contacts.Find(Id);
            db.Contacts.Remove(contactFind);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public void ParEditor(Contact contactPAr)
        {
            
            Response.Write(string.Format("Name: {0}, LastName: {1}", contactPAr.NAme, contactPAr.LastNAme));
            
        }
    }
}