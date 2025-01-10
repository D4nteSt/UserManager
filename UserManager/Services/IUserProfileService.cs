using UserManager.Models;

namespace UserManager.Services;

public interface IUserProfileService
{
    Task<IEnumerable<UserProfile>> GetUserProfilesAsync();
    Task<UserProfile> GetUserProfileByIdAsync(int userProfileId);
    Task<UserProfile> AddUserProfileAsync(UserProfile userProfile);
    Task<UserProfile> UpdateUserProfileAsync(UserProfile userProfile);
    Task<UserProfile> DeleteUserProfileAsync(int userProfileId);
}