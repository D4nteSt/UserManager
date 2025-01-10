using Microsoft.EntityFrameworkCore;
using UserManager.Models;

namespace UserManager.DataAccess.Repositories;

public class UserProfileRepository : IUserProfileRepository
{
    private readonly DatabaseContext _context;

    public UserProfileRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<UserProfile>> GetUserProfilesAsync()
    {
        return await _context.UserProfiles.ToListAsync();
    }

    public async Task<UserProfile> GetUserProfileByIdAsync(int userProfileId)
    {
        return await _context.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileId == userProfileId);
    }

    public async Task<UserProfile> AddUserProfileAsync(UserProfile userProfile)
    {
        await _context.UserProfiles.AddAsync(userProfile);
        await _context.SaveChangesAsync();
        return userProfile;
    }

    public async Task<UserProfile> UpdateUserProfileAsync(UserProfile userProfile)
    {
        _context.UserProfiles.Update(userProfile);
        await _context.SaveChangesAsync();
        return userProfile;
    }

    public async Task<UserProfile> DeleteUserProfileAsync(int userProfileId)
    {
        var userProfile = await _context.UserProfiles.FirstOrDefaultAsync(up => up.UserProfileId == userProfileId);
        if (userProfile != null)
        {
            _context.UserProfiles.Remove(userProfile);
            await _context.SaveChangesAsync();
        }
        return userProfile;
    }
}