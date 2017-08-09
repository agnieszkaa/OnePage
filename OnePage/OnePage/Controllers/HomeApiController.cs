using OnePage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace OnePage.Controllers
{
    public class HomeApiController : Controller
    {
        

        public JsonResult ShowContacts(string name, string lastName)
        {
            KontaktyDatabase db = new KontaktyDatabase();
            var items = db.Contacts;
            var list = items.ToList();

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

        [System.Web.Http.HttpDelete]
        public void Delete(int id)
        {
            KontaktyDatabase db = new KontaktyDatabase();
            //int Id = Int32.Parse(id);
            Contact contactFind = db.Contacts.Find(id);
            db.Contacts.Remove(contactFind);
            db.SaveChanges();

        }


        //[HttpPost]
        //public async Task<HttpResponseMessage> OrderDetailsPost(HttpRequestMessage request)
        //{
        //    var packingListElements = await request.Content.ReadAsAsync<CreatePackingListQuery.CollectorPackingList>();

        //    if (!HasAnyProducts(packingListElements))
        //    {
        //        return CreateErrorResponse(Request, HttpStatusCode.BadRequest, "Nie wybrano elementow dla dokumentu WZ");

        //    }
        //}
            //public void ParEditor(Contact contactPar)
            //{

            //    System.Console.WriteLine(string.Format("Name: {0}, LastName: {1}", contactPar.name, contactPar.lastName));

            //}

    }
}

