using UserManager.Models;
using UserManager.DataAccess.Repositories;
namespace UserManager.Services;

public class SessionService : ISessionService
{
    private readonly IUserRepository _userRepository;
    private User _currentUser;

    public SessionService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    // Получить текущего пользователя из сессии
    public async Task<User> GetLoggedInUserAsync()
    {
        return _currentUser;
    }

    // Логин пользователя, сохраняем информацию о текущем пользователе
    public async Task LogInAsync(User user)
    {
        // Проверка, если пользователь существует в базе данных
        var existingUser = await _userRepository.GetUserByIdAsync(user.UserId);
        if (existingUser != null)
        {
            _currentUser = existingUser;  // Сохраняем пользователя в текущую сессию
        }
        else
        {
            throw new Exception("Пользователь не найден.");
        }
    }

    // Логаут пользователя
    public async Task LogOutAsync()
    {
        _currentUser = null;  // Удаляем текущего пользователя из сессии
    }
}
