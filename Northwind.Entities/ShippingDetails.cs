using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage ="Name can not be null!")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required()]
        [MinLength(10)]
        [MaxLength(50)]
        [Display(Name = "Address 1")]
        public string Address1 { get; set; }
        [MinLength(10)]
        [MaxLength(50)]
        [Display(Name = "Address 2")]
        public string Address2 { get; set; }
        [MinLength(10)]
        [MaxLength(50)]
        [Display(Name = "Address 3")]
        public string Address3 { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "Country")]
        public string Country { get; set; }
        [Display(Name = "Gift")]
        public bool IsGift { get; set; }
    }
}
