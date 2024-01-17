using Recipe.DataAccess.Repositary.IRepositary;
using Recipe.Models;

public interface ICategory:IRepositary<Category>
{
    void Update(Category category);
    IEnumerable<Category> TopCategory();
}