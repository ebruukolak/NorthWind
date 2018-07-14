using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.MVCWebUI.Models
{
    public class CategoryViewModel
    {
        public List<Product> Products{ get; set; }
        public List<Category> Categories { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}