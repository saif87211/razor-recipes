using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipe.Models;

public class Recipe
{
    [Key]
    public int RecipeId { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Ingredients { get; set; } = null!;
    public string Instructions { get; set; } = null!;
    [Required]
    public int CookingTime { get; set; }
    [ForeignKey("Author")]
    public int AuthorID { get; set; }
    public virtual required User Author { get; set; }
    [Required]
    public DateTime DatePublished { get; set; }
    [ForeignKey("Category")]
    public int CategoryID { get; set; }

    public virtual Category Category { get; set; }

    public virtual ICollection<Comment> Comments { get; set; }
    public virtual ICollection<Rating> Ratings { get; set; }

}
