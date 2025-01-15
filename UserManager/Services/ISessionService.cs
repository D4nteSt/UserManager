using UserManager.Models;

namespace UserManager.Services;

public interface ISessionService
{
    Task<User> GetLoggedInUserAsync();
    Task LogInAsync(User user);
    Task LogOutAsync();
}