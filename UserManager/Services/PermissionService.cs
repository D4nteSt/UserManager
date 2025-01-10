using UserManager.DataAccess.Repositories;
using UserManager.Models;

namespace UserManager.Services;

public class PermissionService : IPermissionService
{
    private readonly IPermissionRepository _permissionRepository;

    public PermissionService(IPermissionRepository permissionRepository)
    {
        _permissionRepository = permissionRepository;
    }

    // Получение всех разрешений
    public async Task<IEnumerable<Permission>> GetPermissionsAsync()
    {
        return await _permissionRepository.GetPermissionsAsync();
    }

    // Получение разрешения по ID
    public async Task<Permission> GetPermissionByIdAsync(int permissionId)
    {
        return await _permissionRepository.GetPermissionByIdAsync(permissionId);
    }

    // Добавление нового разрешения
    public async Task<Permission> AddPermissionAsync(Permission permission)
    {
        var existingPermission = await _permissionRepository.GetPermissionByIdAsync(permission.PermissionId);
        if (existingPermission != null)
        {
            throw new Exception("Разрешение уже существует");
        }
        return await _permissionRepository.AddPermissionAsync(permission);
    }

    // Обновление существующего разрешения
    public async Task<Permission> UpdatePermissionAsync(Permission permission)
    {
        return await _permissionRepository.UpdatePermissionAsync(permission);
    }

    // Удаление разрешения
    public async Task<Permission> DeletePermissionAsync(int permissionId)
    {
        var permission = await _permissionRepository.GetPermissionByIdAsync(permissionId);
        if (permission == null)
        {
            throw new Exception("Разрешение не найдено.");
        }

        return await _permissionRepository.DeletePermissionAsync(permissionId);
    }
}