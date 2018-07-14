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
   public class AuthenticateService : IAuthenticateService
   {
      AuthenticateManager authenticate = new AuthenticateManager(new AuthenticateDAL());
      public User Authenticate(User user)
      {
         return authenticate.Authenticate(user);
      }
   }
}