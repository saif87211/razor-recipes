using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using Recipe.Models;

namespace Recipe.DataAccess.Data;
public class RecipeDbContext : DbContext
{
    public RecipeDbContext()
    {
        
    }
    public RecipeDbContext(DbContextOptions<RecipeDbContext> options) :base(options)
    {
        
    }
    public DbSet<Category> Category { get; set; }
    public DbSet<Models.Recipe> Recipe { get; set; }
    public DbSet<Comment> Comment { get; set; }
    public DbSet<Rating> Rating { get; set; }
    
}