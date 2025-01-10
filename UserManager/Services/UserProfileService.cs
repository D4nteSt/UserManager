using UserManager.DataAccess.Repositories;
using UserManager.Models;

namespace UserManager.Services;

public class UserProfileService : IUserProfileService
{
    private readonly IUserProfileRepository _userProfileRepository;

    public UserProfileService(IUserProfileRepository userProfileRepository)
    {
        _userProfileRepository = userProfileRepository;
    }

    public async Task<IEnumerable<UserProfile>> GetUserProfilesAsync()
    {
        return await _userProfileRepository.GetUserProfilesAsync();
    }

    public async Task<UserProfile> GetUserProfileByIdAsync(int userProfileId)
    {
        return await _userProfileRepository.GetUserProfileByIdAsync(userProfileId);
    }

    public async Task<UserProfile> AddUserProfileAsync(UserProfile userProfile)
    {
        var existingUserProfile = await _userProfileRepository.GetUserProfileByIdAsync(userProfile.UserProfileId);
        if (existingUserProfile != null)
        {
            throw new Exception($"Профиль пользователя {userProfile.UserId} уже существует");
        }
        return await _userProfileRepository.AddUserProfileAsync(userProfile);
    }

    public async Task<UserProfile> UpdateUserProfileAsync(UserProfile userProfile)
    {
        return await _userProfileRepository.UpdateUserProfileAsync(userProfile);
    }

    public async Task<UserProfile> DeleteUserProfileAsync(int userProfileId)
    {
        var userProfile = await _userProfileRepository.GetUserProfileByIdAsync(userProfileId);
        if (userProfile == null)
        {
            throw new Exception($"Профиль пользователя {userProfile.UserId} не найден");
        }

        return await _userProfileRepository.DeleteUserProfileAsync(userProfileId);
    }
}