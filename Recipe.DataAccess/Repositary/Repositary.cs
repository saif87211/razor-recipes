using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Recipe.DataAccess.Data;
using Recipe.DataAccess.Repositary.IRepositary;

namespace Recipe.DataAccess.Repositary;

public class Repositary<T> : IRepositary<T> where T : class
{
    private readonly RecipeDbContext _db;
    internal DbSet<T> dbSet;

    public Repositary(RecipeDbContext recipeDb)
    {
        _db = recipeDb;
        dbSet = recipeDb.Set<T>();
    }
    public void Add(T Enitity)
    {
        _db.Add(Enitity);
    }

    public IEnumerable<T> GetAll()
    {
        IQueryable<T> query = dbSet;
        return query.ToList();
    }

    public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
    {
        IQueryable<T> query = dbSet;
        if(filter!=null)
        {
            query =query.Where(filter);
        }
        return query.FirstOrDefault();
    }

    public void Remove(T enitity)
    {
        _db.Remove(enitity);
    }

    public void RemoveRange(IEnumerable<T> enitity)
    {
        _db.RemoveRange(enitity);
    }
}