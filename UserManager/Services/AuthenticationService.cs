using UserManager.DataAccess.Repositories;
using UserManager.Models;

namespace UserManager.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IUserRepository _userRepository;
    private readonly ISessionService _sessionService;
    private readonly IPasswordHasher _passwordHasher;

    public AuthenticationService(IUserRepository userRepository, ISessionService sessionService, IPasswordHasher passwordHasher)
    {
        _userRepository = userRepository;
        _sessionService = sessionService;
        _passwordHasher = passwordHasher;
    }

    // Аутентификация пользователя
    public async Task<User> AuthenticateAsync(string username, string password)
    {
        // Получаем пользователя по имени
        var user = await _userRepository.GetUserByUsernameAsync(username);
        if (user == null) return null;  // Пользователь не найден

        // Проверяем пароль
        if (!_passwordHasher.VerifyPassword(password, user.PasswordHash))
        {
            return null;  // Неверный пароль
        }

        // Логиним пользователя
        await _sessionService.LogInAsync(user);

        return user;  // Успешная аутентификация
    }

    // Логин пользователя
    public async Task LogInAsync(User user)
    {
        // Сохраняем информацию о текущем пользователе в сессии
        await _sessionService.LogInAsync(user);
    }

    // Логаут пользователя
    public async Task LogOutAsync()
    {
        await _sessionService.LogOutAsync();  // Удаляем пользователя из сессии
    }

    // Получение текущего вошедшего пользователя
    public async Task<User> GetLoggedInUserAsync()
    {
        return await _sessionService.GetLoggedInUserAsync();  // Получаем текущего пользователя из сессии
    }
}