using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewExample.Models
{
    public class Person
    {
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Gender Persongender{ get; set; }
    }

    public enum Gender {
        Male, Female, Other
    }
}