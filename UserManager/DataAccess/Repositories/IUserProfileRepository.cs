using UserManager.Models;

namespace UserManager.DataAccess.Repositories;

public interface IUserProfileRepository
{
    Task<IEnumerable<UserProfile>> GetUserProfilesAsync();
    Task<UserProfile> GetUserProfileByIdAsync(int userProfileId);
    Task<UserProfile> AddUserProfileAsync(UserProfile user);
    Task<UserProfile> UpdateUserProfileAsync(UserProfile user);
    Task<UserProfile> DeleteUserProfileAsync(int userProfileId);
}    
