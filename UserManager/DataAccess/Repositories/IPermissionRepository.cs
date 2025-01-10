using UserManager.Models;

namespace UserManager.DataAccess.Repositories;

public interface IPermissionRepository
{
    Task<IEnumerable<Permission>> GetPermissionsAsync();
    Task<Permission> GetPermissionByIdAsync(int permissionId);
    Task<Permission> AddPermissionAsync(Permission permission);
    Task<Permission> UpdatePermissionAsync(Permission permission);
    Task<Permission> DeletePermissionAsync(int permissionId);
}