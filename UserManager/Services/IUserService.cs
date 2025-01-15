using UserManager.Models;

namespace UserManager.Services;

public interface IUserService
{
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User> GetUserByIdAsync(int userId);
    Task<User> GetUserByUsernameAsync(string username);
    Task<bool> RegisterUserAsync(string username, string plainPassword, string email);
    Task ChangePasswordAsync(int userId, string oldPassword, string newPassword);
    Task<User> AuthenticateAsync(string username, string plainPassword);
    Task<User> AddUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
    Task<User> DeleteUserAsync(int userId);
    Task<bool> IsEmailTakenAsync(string email);
    Task<bool> IsUsernameTakenAsync(string username);
}