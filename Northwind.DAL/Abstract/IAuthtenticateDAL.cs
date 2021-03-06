﻿using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Abstract
{
   public interface IAuthtenticateDAL
   {
      User Authenticate(User user);

      User GetAdminUser(User user);
   }
}
