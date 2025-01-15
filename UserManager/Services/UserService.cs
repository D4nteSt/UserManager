using UserManager.DataAccess.Repositories;
using UserManager.Models;

namespace UserManager.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPasswordHasher _passwordHasher;
        public UserService(IUserRepository userRepository, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _userRepository.GetUsersAsync();
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _userRepository.GetUserByIdAsync(userId);
        }
        
        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await _userRepository.GetUserByUsernameAsync(username);
        }
        public async Task<bool> RegisterUserAsync(string username, string password, string email)
    {
        // Проверяем, есть ли пользователь с таким именем
        var existingUser = await _userRepository.GetUserByUsernameAsync(username);
        if (existingUser != null)
        {
            throw new Exception("Пользователь с таким именем уже существует.");
        }

        // Хэшируем пароль
        var hashedPassword = _passwordHasher.HashPassword(password);

        // Создаём нового пользователя
        var user = new User
        {
            Username = username,
            PasswordHash = hashedPassword,
            Email = email,
            CreatedDate = DateTime.Now,
            Status = "Active"
        };

        await _userRepository.AddUserAsync(user);
        return true;
    }

    public async Task<User> AuthenticateAsync(string username, string plainPassword)
    {
        // Ищем пользователя по имени
        var user = await _userRepository.GetUserByUsernameAsync(username);
        if (user == null)
        {
            throw new Exception("Пользователь не найден.");
        }

        // Проверяем пароль
        var isValidPassword = _passwordHasher.VerifyPassword(plainPassword, user.PasswordHash);
        if (!isValidPassword)
        {
            throw new Exception("Неверный пароль.");
        }

        return user;
    }

    public async Task ChangePasswordAsync(int userId, string oldPassword, string newPassword)
    {
        // Ищем пользователя
        var user = await _userRepository.GetUserByIdAsync(userId);
        if (user == null)
        {
            throw new Exception("Пользователь не найден.");
        }

        // Проверяем текущий пароль
        if (!_passwordHasher.VerifyPassword(oldPassword, user.PasswordHash))
        {
            throw new Exception("Неверный текущий пароль.");
        }

        // Хэшируем новый пароль и обновляем пользователя
        user.PasswordHash = _passwordHasher.HashPassword(newPassword);
        await _userRepository.UpdateUserAsync(user);
    }
        public async Task<User> AddUserAsync(User user)
        {
            var existingUser = await _userRepository.GetUserByIdAsync(user.UserId);
            if (existingUser != null)
            {
                throw new Exception($"Пользователь {user.Username} уже существует");
            }

            return await _userRepository.AddUserAsync(user);
        }

        public async Task<User> UpdateUserAsync(User user)
        {
            return await _userRepository.UpdateUserAsync(user);
        }

        public async Task<User> DeleteUserAsync(int userId)
        {
            var user = await _userRepository.GetUserByIdAsync(userId);
            if (user == null)
            {
                throw new Exception($"Пользователь {user.Username} не найден");
            }

            return await _userRepository.DeleteUserAsync(userId);
        }
        public async Task<bool> IsEmailTakenAsync(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email не может быть пустым.", nameof(email));
            }

            return await _userRepository.ExistsAsync(u => u.Email.ToLower() == email.ToLower());
        }
        public async Task<bool> IsUsernameTakenAsync(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Имя пользователя не может быть пустым.", nameof(username));
            }

            return await _userRepository.ExistsAsync(u => u.Username.ToLower() == username.ToLower());
        }
    }
}