namespace UserManager.Models;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Email { get; set; }
    public string Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    
    public ICollection<Role> Roles { get; set; }
    public ICollection<ActivityLog> ActivityLogs { get; set; }
    public ICollection<Subscription> Subscriptions { get; set; }
}