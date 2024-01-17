using System.Linq.Expressions;

namespace Recipe.DataAccess.Repositary.IRepositary;

public interface IRepositary<T> where T : class
{
    IEnumerable<T> GetAll();
    T GetFirstOrDefault(Expression<Func<T,bool>> filter);
    void Add(T enitity);
    void Remove(T enitity);
    void RemoveRange(IEnumerable<T> enitity);
}