using Recipe.DataAccess.Data;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly RecipeDbContext _db;

    public ICategory Category {get; private set;}
    public IRecipe Recipe {get; private set;}

    public UnitOfWork(RecipeDbContext recipeDb)
    {
        _db =recipeDb;
        Category = new CategoryRepositary(recipeDb);
        Recipe = new RecipeRepositary(recipeDb);
    }
    public void Save()
    {
        _db.SaveChanges();
    }

    public void Dispose()
    {
        _db.Dispose();
    }
}