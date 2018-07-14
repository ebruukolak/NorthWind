using Northwind.DAL.Abstract;
using Northwind.Entities;
using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Bussines.Concrete
{
   public class AuthenticateManager : IAuthenticateService
   {
      IAuthtenticateDAL authtenticateDAL;
      public AuthenticateManager(IAuthtenticateDAL authtenticate)
      {
         authtenticateDAL = authtenticate;
      }

      public User Authenticate(User user)
      {
         return authtenticateDAL.Authenticate(user);         
      }
   }
}
