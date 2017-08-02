using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace BaseFirst.Models
{
    public partial class KontaktyDatabase : DbContext
    {
        public KontaktyDatabase() : base (
            "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\db\\KontaktyDatabase.mdf\";Integrated Security=True;Connect Timeout=30"
            )
        { }
        public DbSet<Contact> Contacts { get; set; }

    }
}