using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipe.Models;

public class Rating
{
    [Key]
    public int RatingId { get; set; }
    [ForeignKey("Recipe")]
    public int RecipeId { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    [Range(1,5)]
    public int RatingValue { get; set; }
    public DateTime DateRated { get; set; }
    public virtual User User { get; set; }
    public virtual Recipe Recipe { get; set; }

}
