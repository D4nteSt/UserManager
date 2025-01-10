using Microsoft.EntityFrameworkCore;
using UserManager.Models;

namespace UserManager.DataAccess.Repositories;

public class PermissionRepository : IPermissionRepository
{
    private readonly DatabaseContext _context;

    public PermissionRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Permission>> GetPermissionsAsync()
    {
        return await _context.Permissions.ToListAsync();
    }

    public async Task<Permission> GetPermissionByIdAsync(int permissionId)
    {
        return await _context.Permissions.FirstOrDefaultAsync(p => p.PermissionId == permissionId);
        
    }

    public async Task<Permission> AddPermissionAsync(Permission permission)
    {
        await _context.Permissions.AddAsync(permission);
        await _context.SaveChangesAsync();
        return permission;
    }

    public async Task<Permission> UpdatePermissionAsync(Permission permission)
    {
        _context.Permissions.Update(permission);
        await _context.SaveChangesAsync();
        return permission;
    }

    public async Task<Permission> DeletePermissionAsync(int permissionId)
    {
        var permission = await _context.Permissions.FirstOrDefaultAsync(p => p.PermissionId == permissionId);
        if (permission != null)
        {
            _context.Permissions.Remove(permission);
            await _context.SaveChangesAsync();
        }
        return permission;
    }
}