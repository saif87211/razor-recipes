using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipe.DataAccess.Data;
using Recipe.Models;

namespace razor_recipes.Pages.Admin.Categories;
public class EditModel : PageModel
{
    private RecipeDbContext _db;
    [BindProperty]
    public Category Category { get; set; }
    public EditModel(RecipeDbContext dbContext)
    {
        _db = dbContext;
    }

    public void OnGet(int id)
    {
        Category = _db.Category.Find(id);
    }

    public async Task<IActionResult> OnPost()
        {
            if(Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError(string.Empty,"The Displayorder cannot Exactly match the name.");
            }
            if(ModelState.IsValid)
            {
                _db.Category.Update(Category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category Edited Succesfully.";
                return RedirectToPage("Index");
            }
            return Page();
        }
}