using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipe.DataAccess.Data;
using Recipe.Models;

namespace razor_recipes.Pages.Admin.Categories;

public class DeleteModel : PageModel
{
    private readonly RecipeDbContext _db;
    [BindProperty]
    public Category Category { get; set; }
    public DeleteModel(RecipeDbContext db)
    {
        _db = db;
    }
    public void OnGet(int id)
    {
        Category = _db.Category.Find(id);
    }

    public async Task<IActionResult> OnPost()
    {
        var CategoryFromDb = _db.Category.Find(Category.Id);
        if (CategoryFromDb != null)
        {
            _db.Remove(CategoryFromDb);
            await _db.SaveChangesAsync();
            TempData["success"] = "Category Delete Succesfully.";
            return RedirectToPage("Index");
        }
        return Page();
    }

}