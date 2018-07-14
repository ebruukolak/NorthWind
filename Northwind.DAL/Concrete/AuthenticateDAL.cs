using Northwind.DAL.Abstract;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Concrete
{
   public class AuthenticateDAL : IAuthtenticateDAL
   {
      NorthwindContext _context = new NorthwindContext();
      public User Authenticate(User user)
      {
         user = GetAdminUser(user);
         if (user.Role == "Admin")
         {
            return user;
         }
         else
         {
            return null;
         }
      }


      public User GetAdminUser(User user)
      {
         if (user != null)
            return _context.Users.FirstOrDefault(x => x.Username == user.Username);
         else
            return null;
      }
   }
}
