using Recipe.DataAccess.Data;
using Recipe.DataAccess.Repositary;
using Recipe.Models;

public class CategoryRepositary : Repositary<Category>, ICategory
{
    private readonly RecipeDbContext _db;
    public CategoryRepositary(RecipeDbContext recipeDb) : base(recipeDb)
    {
        _db = recipeDb;
    }

    public IEnumerable<Category> TopCategory()
    {
        IEnumerable<Category> categories = _db.Category.Take(10).ToList();
        return categories;
    }

    public void Update(Category category)
    {
        _db.Category.Update(category);
    }
}