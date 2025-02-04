using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhetherAppExampleForView.Models
{
    public class CityWhether
    {
        public string? CityUniqueCode { get; set; }
        public string? CityName { get; set; }
        public DateTime DateAndTime { get; set; }
        public int TemperatureFahrenheit { get; set; }

    }

}