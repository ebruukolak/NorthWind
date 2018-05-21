using Northwind.Bussines.Concrete;
using Northwind.DAL.Concrete;
using Northwind.Entities;
using Northwind.Interfaces;
using Northwind.MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {

        private IProductService _productService;
        public int pageSize = 5;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Product
        public ActionResult Index(int page = 1,int category=0)
        {
            List<Product> products = _productService.GetAll().Where(x=>x.CategoryID==category || category==0).ToList();
            return View(new ProductViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(5).ToList(),
                PagingInfo = new PagingInfo
                {
                    ItemsPageSize = pageSize,
                    TotalCount = products.Count,
                    CurrentPage = page,
                    CurrentCategory=category
                }
            });
        }
    }
}