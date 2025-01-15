using UserManager.Models;
using System.Linq.Expressions;

namespace UserManager.DataAccess.Repositories;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetUsersAsync();
    Task<User> GetUserByIdAsync(int userId);
    Task<User> GetUserByUsernameAsync(string username);
    Task<User> AddUserAsync(User user);
    Task<User> UpdateUserAsync(User user);
    Task<User> DeleteUserAsync(int userId);
    Task<bool> ExistsAsync(Expression<Func<User, bool>> predicate);
}