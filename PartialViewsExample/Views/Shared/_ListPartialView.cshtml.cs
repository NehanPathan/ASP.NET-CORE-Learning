using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PartialViewsExample.Views.Shared
{
    public class _ListPartialView : PageModel
    {
        private readonly ILogger<_ListPartialView> _logger;

        public _ListPartialView(ILogger<_ListPartialView> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}