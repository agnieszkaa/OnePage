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

       

        public ActionResult Editor(Contact newContact, string NAme, string LastNAme)
        {
            var contact = (string.Format("NAme:{0}, LastNAme:{1}", NAme,LastNAme));
            ViewBag.Message = "Add your name";
            KontaktyDatabase db = new KontaktyDatabase();


            var dane = db.Contacts;

            db.Contacts.Add(newContact);
            db.SaveChanges();

            //private void button1_Click(object sender, EventArgs e)
            //{
            //    sqlCEC.Open();

            //    //Project_List.Items.Add(new_project_name.Text.ToString());
            //    SqlCeCommand sqlCEcommand = new SqlCeCommand("INSERT INTO Project Table(Project Name) VALUES(@Project Name)", sqlCEC);
            //    sqlCEcommand.Parameters.AddWithValue("@Project Name", new_project_name.Text);

            //    sqlCEcommand.ExecuteNonQuery();

            //    sqlCEC.Close();
            //}
            return View( dane);
        }
        public void ParEditor(Contact contactPAr)
        {
            //KontaktyDatabase db = new KontaktyDatabase();
            Response.Write(string.Format("Name: {0}, LastName: {1}", contactPAr.NAme, contactPAr.LastNAme));
            //db.Contacts.Add(contactPAr);
            //db.SaveChanges();
        }
    }
}