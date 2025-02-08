using Microsoft.AspNetCore.Identity;
using System;

namespace CitiesManager.Core.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? PersonName { get; set; } 
    }
}
