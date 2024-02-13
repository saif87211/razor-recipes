using Recipe.DataAccess.Data;
using Recipe.DataAccess.Repositary;

public class RecipeRepositary : Repositary<Recipe.Models.Recipe>, IRecipe
{
    private readonly RecipeDbContext _db;
    public RecipeRepositary(RecipeDbContext recipeDb) : base(recipeDb)
    {
        _db = recipeDb;
    }

    public void Update(Recipe.Models.Recipe recipe)
    {
        _db.Recipe.Update(recipe);
    }
}