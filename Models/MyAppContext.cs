using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PdfDocxFileConvertToBase64.Models
{
    public class MyAppContext : DbContext
    {
        public MyAppContext() : base("name=MyAppContext")
        {
        }
        public DbSet<Document> DocumentTable { get; set; }
    }
}