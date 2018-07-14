using Northwind.DAL.Abstract;
using Northwind.DAL.Concrete;
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
   public class AccountController : Controller
   {
      IAuthenticateService authenticateService;

      public object ICategoryDal { get; private set; }

      public AccountController(IAuthenticateService authenticate)
      {
         authenticateService = authenticate;
      }

      // GET: Account
      public ActionResult Login()
      {
         return View(new User());
      }

      [HttpPost]
      public ActionResult Login(User user, string returnURL)
      {
         User isUser = authenticateService.Authenticate(user);
         if (isUser == null)
         {
            ModelState.AddModelError("Error:", "Username or password is wrong");
            return View();
         }
         else
         {
            if (ModelState.IsValid)
            {
               FormsAuthentication.SetAuthCookie(user.Username, false);
               return Redirect("~/Admin/Index");
            }
         }
         return View();
      }

   }
}