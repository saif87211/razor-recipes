using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipe.Models;

public class Comment
{
    [Key]
    public int CommentId { get; set; }
    [ForeignKey("Recipe")]
    public int RecipeId { get; set; }
    public required string CommentText { get; set; }
    public DateTime DatePosted { get; set; }
    public virtual Recipe Recipe { get; set; } = null!;
}