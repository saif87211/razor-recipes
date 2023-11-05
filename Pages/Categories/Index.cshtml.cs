using Microsoft.AspNetCore.Mvc.RazorPages;
using razor_recipes.Data;
using razor_recipes.Model;

namespace razor_recipes.Pages.Categories;

public class IndexModel : PageModel
{
    private readonly RecipeDbContext _db;
    public IEnumerable<Category> categories { get; set; }

    public IndexModel(RecipeDbContext recipeDbContext)
    {
        _db = recipeDbContext;
    }

    public void OnGet()
    {
        categories = _db.Category.ToList();
    }
}