using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using razor_recipes.Model;

namespace razor_recipes.Data;
public class RecipeDbContext : DbContext
{
    public RecipeDbContext(DbContextOptions<RecipeDbContext> options) :base(options)
    {
        
    }
    public DbSet<Category> Category { get; set; }
    
}