using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Practice_2.Models;

namespace Practice_2.CustomValidators
{
    public class InvoicePriceValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
             var order = (Order)validationContext.ObjectInstance;

        if (order == null)
        {
            return new ValidationResult("Order object is null.");
        }

        if (order.Products == null || !order.Products.Any())
        {
            return new ValidationResult("Product list is empty or missing.");
        }

        // Calculate the total cost of products
        double totalProductCost = order.Products.Sum(p => p.Price * p.Quantity);

        // Check if InvoicePrice matches the total product cost
        if (Math.Abs(order.InvoicePrice - totalProductCost) < 0.01) // Allowing a small tolerance for floating point comparison
        {
            return ValidationResult.Success;
        }

        return new ValidationResult($"Invoice Price must be equal to the total cost of all products which is {totalProductCost}.");
        }
    }
}