using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_recipes.Data;
using razor_recipes.Model;
namespace razor_recipes.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly RecipeDbContext _db;

        [BindProperty]
        public Category Category { get; set; }
        
        public CreateModel(RecipeDbContext dbContext)
        {
            _db = dbContext;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            await _db.Category.AddAsync(Category);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}