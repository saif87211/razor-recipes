using Recipe.DataAccess.Repositary.IRepositary;

public interface IRecipe : IRepositary<Recipe.Models.Recipe>
{
    void Update(Recipe.Models.Recipe recipe);
}