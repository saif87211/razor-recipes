public interface IUnitOfWork:IDisposable
{
    ICategory category{get;}
    void Complete();
}