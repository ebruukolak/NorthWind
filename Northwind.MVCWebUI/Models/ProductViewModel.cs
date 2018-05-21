using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind.MVCWebUI.Models
{
    public class ProductViewModel
    {
       public List<Product> Products { get; set; }
       public PagingInfo PagingInfo;
    }
}