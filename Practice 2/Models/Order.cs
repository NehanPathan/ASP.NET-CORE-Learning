using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Practice_2.CustomValidators;

namespace Practice_2.Models
{
    public class Order
    {
        public int? OrderNo { get; set; }

        public DateTime OrderDate { get; set; }

        [Required]
        [InvoicePriceValidation]
        
        public double InvoicePrice { get; set; }

        public List<Product> Products { get; set; }
    }
}