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
        public ActionResult AddToCart(int productID)
        {
            Product product=_productService.Get(productID);
            var cart = (Cart)Session["cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["cart"] = cart;
            }
            cart.AddToCart(product,1);
            return View("Index");
        }
    }
}