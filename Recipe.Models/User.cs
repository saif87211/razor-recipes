using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Recipe.Models;
public class User
{
    [Key]
    public int UserId { get; set; }
    [Display(Name = "Username")]
    public string UserName { get; set; } = null!;
    [EmailAddress]
    public string Email { get; set; } = null!;
    [PasswordPropertyText]
    public string Password { get; set; } = null!;
    public string ProfilePicture { get; set; } = null!;
}