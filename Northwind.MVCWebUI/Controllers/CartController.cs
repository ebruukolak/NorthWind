using Northwind.Entities;
using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.MVCWebUI.Content.Controllers
{
   public class CartController : Controller
   {
      IProductService _productService;
      public CartController(IProductService productService)
      {
         _productService = productService;
      }
      // GET: Cart
      public RedirectToRouteResult AddToCart(Cart cart, int productID)
      {
         Product product = _productService.Get(productID);
         cart.AddToCart(product, 1);
         return RedirectToAction("Index", cart);
      }

      public RedirectToRouteResult RemoveFromCart(Cart cart, int productID)
      {
         Product product = _productService.Get(productID);

         cart.RemoveFromCart(product);

         return RedirectToAction("Index", cart);
      }

      public ViewResult Index(Cart cart)
      {
         return View(cart);
      }

      [HttpGet]
      public ActionResult Checkout()
      {
         return View(new ShippingDetails());
      }

      [HttpPost]
      public ActionResult Checkout(ShippingDetails shippingDetails)
      {
         if (ModelState.IsValid)
         {
            return View("Completed");
         }
         else
         {
            return View(shippingDetails);
         }

      }

      public PartialViewResult CartSummary(Cart cart)
      {
         return PartialView(cart);
      }
   }


}