using System.ComponentModel.DataAnnotations.Schema;

namespace UserManager.Models;

public class UserProfile
{
    public int UserProfileId { get; set; }
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string AvatarURL { get; set; }
    public string Bio { get; set; }
    
    public User User { get; set; }
    
    [NotMapped]
    public string FullName => $"{FirstName} {LastName}";
}