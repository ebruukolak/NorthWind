using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities
{
   public class User
   {
      public int ID { get; set; }
      public string Name { get; set; }
      [Required]
      public string Username { get; set; }
      public string Role { get; set; }
      [Required]
      [DataType(DataType.Password)]
      public string Password { get; set; }
   }
}
