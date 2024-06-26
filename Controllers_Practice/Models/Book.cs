using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Controllers_Practice.Models
{
    public class Book
    {
        // [FromQuery]
        public int? BookId { get; set; }
        public string? Author { get; set; }
        public override string ToString()
        {
            return $"Book Object - Book id: {BookId}, Author: {Author}";
        }
    }
}
