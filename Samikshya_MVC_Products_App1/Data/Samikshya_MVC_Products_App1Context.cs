using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Samikshya_MVC_Products_App1.Data
{
    public class Samikshya_MVC_Products_App1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Samikshya_MVC_Products_App1Context() : base("name=Samikshya_MVC_Products_App1Context")
        {
        }

        public System.Data.Entity.DbSet<Samikshya_MVC_Products_App1.Models.Brand> Brands { get; set; }

        public System.Data.Entity.DbSet<Samikshya_MVC_Products_App1.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<Samikshya_MVC_Products_App1.Models.Product> Products { get; set; }
    }
}
