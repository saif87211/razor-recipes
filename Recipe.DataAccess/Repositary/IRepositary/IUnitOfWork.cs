public interface IUnitOfWork:IDisposable
{
    ICategory Category{get;}
    IRecipe Recipe { get; }

    void Save();
}