public interface IUnitOfWork:IDisposable
{
    ICategory Category{get;}
    void Save();
}