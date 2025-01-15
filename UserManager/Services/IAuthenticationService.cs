using UserManager.Models;

namespace UserManager.Services;

public interface IAuthenticationService
{
    Task<User> AuthenticateAsync(string username, string password);
    Task LogInAsync(User user);
    Task LogOutAsync();
    Task<User> GetLoggedInUserAsync();
}