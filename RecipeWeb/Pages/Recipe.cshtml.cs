using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razor_recipes.Pages
{
    public class Recipe : PageModel
    {
        private readonly ILogger<Recipe> _logger;

        public Recipe(ILogger<Recipe> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}