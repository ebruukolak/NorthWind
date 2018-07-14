using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities;

namespace Northwind.DAL.Concrete
{
   public class NorthwindContext : DbContext
   {
      public DbSet<Product> Products { get; set; }
      public DbSet<Category> Categories { get; set; }
      public DbSet<User> Users { get; set; }

   }
}
