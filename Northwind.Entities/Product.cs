using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Northwind.Entities
{
   public class Product
   {
      public int ProductID { get; set; }
      [Required]
      [Display(Name ="Name")]
      public string ProductName { get; set; }
      [Required]
      [Display(Name = "Price")]
      public decimal UnitPrice { get; set; }
      public int CategoryID { get; set; }
      public Category Category { get; set; }

   }
}
