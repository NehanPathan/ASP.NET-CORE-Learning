using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_2.Models
{
    public class Product
    {
        
        public int ProductCode { get; set;}


        [Required(ErrorMessage = "{0} can't be blank")]
        [Display(Name = "Product Price")]
          [Range(1, double.MaxValue, ErrorMessage = "{0} should be between a valid number")]
        public double Price { get; set;}

        [Required(ErrorMessage = "{0} can't be blank")]
        [Display(Name = "Product Quantity")]
          [Range(1, double.MaxValue, ErrorMessage = "{0} should be between a valid number")]
         public int Quantity { get; set;}
    }
}