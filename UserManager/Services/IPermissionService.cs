using UserManager.Models;

namespace UserManager.Services;

public interface IPermissionService
{
    Task<IEnumerable<Permission>> GetPermissionsAsync();
    Task<Permission> GetPermissionByIdAsync(int permissionId);
    Task<Permission> AddPermissionAsync(Permission permission);
    Task<Permission> UpdatePermissionAsync(Permission permission);
    Task<Permission> DeletePermissionAsync(int permissionId);
}