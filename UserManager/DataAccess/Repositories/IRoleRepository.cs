using UserManager.Models;

namespace UserManager.DataAccess.Repositories;

public interface IRoleRepository
{
    Task<IEnumerable<Role>> GetRolesAsync();
    Task<Role> GetRoleByIdAsync(int roleId);
    Task<Role> AddRoleAsync(Role role);
    Task<Role> UpdateRoleAsync(Role role);
    Task<Role> DeleteRoleAsync(int roleId);
}