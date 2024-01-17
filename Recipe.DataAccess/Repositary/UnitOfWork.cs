using Recipe.DataAccess.Data;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly RecipeDbContext _db;

    public ICategory category {get; private set;}

    public UnitOfWork(RecipeDbContext recipeDb)
    {
        _db =recipeDb;
        category = new CategoryRepositary(recipeDb);
    }
    public void Complete()
    {
        _db.SaveChanges();
    }

    public void Dispose()
    {
        _db.Dispose();
    }
}