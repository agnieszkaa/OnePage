﻿using BaseFirst.Models;

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
    }
}