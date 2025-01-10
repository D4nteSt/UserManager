using UserManager.DataAccess.Repositories;
using UserManager.Models;
 
namespace UserManager.Services;

public class RoleService : IRoleService
{
    private readonly IRoleRepository _roleRepository;

    public RoleService(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    // Получение всех ролей
    public async Task<IEnumerable<Role>> GetRolesAsync()
    {
        return await _roleRepository.GetRolesAsync();
    }

    // Получение роли по ID
    public async Task<Role> GetRoleByIdAsync(int roleId)
    {
        return await _roleRepository.GetRoleByIdAsync(roleId);
    }

    // Добавление новой роли
    public async Task<Role> AddRoleAsync(Role role)
    {
        var existingRole = await _roleRepository.GetRoleByIdAsync(role.RoleId);
        if (existingRole != null)
        {
            throw new Exception($"Роль с Id {role.RoleId} уже существует");
        }
        return await _roleRepository.AddRoleAsync(role);
    }

    // Обновление существующей роли
    public async Task<Role> UpdateRoleAsync(Role role)
    {
        return await _roleRepository.UpdateRoleAsync(role);
    }

    // Удаление роли
    public async Task<Role> DeleteRoleAsync(int roleId)
    {
        var role = await _roleRepository.GetRoleByIdAsync(roleId);
        if (role == null)
        {
            throw new Exception("Роль не найдена.");
        }

        return await _roleRepository.DeleteRoleAsync(roleId);
    }
}