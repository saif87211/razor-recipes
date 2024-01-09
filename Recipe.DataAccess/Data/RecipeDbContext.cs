using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using Recipe.Models;

namespace Recipe.DataAccess.Data;
public class RecipeDbContext : DbContext
{
    public RecipeDbContext(DbContextOptions<RecipeDbContext> options) :base(options)
    {
        
    }
    public DbSet<Category> Category { get; set; }
    
}