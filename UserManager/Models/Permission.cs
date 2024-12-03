namespace UserManager.Models;

public class Permission
{
    public int PermissionId { get; set; }
    public string PermissionName { get; set; }
    public string Description { get; set; }
    
    public ICollection<Role> Roles { get; set; }
}