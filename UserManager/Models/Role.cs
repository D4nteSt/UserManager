namespace UserManager.Models;

public class Role
{
    public int RoleId { get; set; }
    public string RoleName { get; set; }
    public string Description { get; set; }
    
    public ICollection<User> Users { get; set; }
    public ICollection<Permission> Permissions { get; set; }
}