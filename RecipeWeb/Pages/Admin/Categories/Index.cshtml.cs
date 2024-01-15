using Microsoft.AspNetCore.Mvc.RazorPages;
using Recipe.DataAccess.Data;
using Recipe.Models;

namespace razor_recipes.Pages.Admin.Categories;

public class IndexModel : PageModel
{
    private readonly RecipeDbContext _db;
    public IEnumerable<Category> categories { get; set; } = new List<Category>();

    public IndexModel(RecipeDbContext recipeDbContext)
    {
        _db = recipeDbContext;
    }

    public void OnGet()
    {
        categories = _db.Category.ToList();
    }
}