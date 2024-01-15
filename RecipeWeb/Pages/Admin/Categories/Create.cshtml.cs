using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipe.DataAccess.Data;
using Recipe.Models;
namespace razor_recipes.Pages.Admin.Categories
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
            if(Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty,"The Displayorder cannot Exactly match the name.");
            }
            if(ModelState.IsValid){
                await _db.Category.AddAsync(Category);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}