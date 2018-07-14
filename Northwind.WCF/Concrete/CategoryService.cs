using Northwind.Bussines.Concrete;
using Northwind.DAL.Concrete;
using Northwind.Entities;
using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.WCF.Concrete
{
   public class CategoryService : ICategoryService
   {
      CategoryManager categoryManager = new CategoryManager(new CategoryDAL());

      public List<Category> GetAll()
      {
         return categoryManager.GetAll();
      }
   }
}