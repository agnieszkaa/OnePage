﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaseFirst.Models
{
    public class ContactDb
    {
        public string Name { get; set; }

        private string lastName;

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string value)
        {
            lastName = value;
        }
    }
}

//public IQueryable<ContactCB> GetBooks()
//{
//    var books = from b in db.Books
//                select new BookDTO()
//                {
//                    Id = b.Id,
//                    Title = b.Title,
//                    AuthorName = b.Author.Name
//                };

//    return books;
//}