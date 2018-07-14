using Northwind.DAL.Abstract;
using Northwind.Entities;
using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Northwind.MVCWebUI.Controllers
{
   public class AdminController : Controller
   {
      IProductService _productService;


      public AdminController(IProductService productService)
      {
         _productService = productService;
      }
      // GET: Admin
      public ActionResult Index()
      {
         return View(_productService.GetAll());
      }

      //[Authorize]
      public ActionResult CreateNew()
      {
         return View(new Product());
      }


      [HttpPost]
      //[Authorize]
      public ActionResult CreateNew(Product product)
      {
         if (ModelState.IsValid)
         {
            _productService.Add(product);
            return RedirectToAction("Index");
         }
         else
            return View(product);

      }


      [HttpGet]
      //[Authorize]
      public ActionResult Edit(int id)
      {
         Product product = _productService.Get(id);
         if (product == null)
         {
            return HttpNotFound();
         }
         return View(product);
      }


      [HttpPost]
      //[Authorize]
      public ActionResult Edit(Product product)
      {
         if (ModelState.IsValid)
         {
            _productService.Update(product);
            return RedirectToAction("Index");
         }
         else
            return View(product);

      }

      public List<Category> GetCategories()
      {
         ICategoryDAL category = null;
         return category.GetAll();
      }
   }
}