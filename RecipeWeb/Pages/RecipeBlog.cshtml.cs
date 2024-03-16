using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razor_recipes.Pages
{
    public class RecipeBlog : PageModel
    {
        private readonly ILogger<RecipeBlog> _logger;

        public RecipeBlog(ILogger<RecipeBlog> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}