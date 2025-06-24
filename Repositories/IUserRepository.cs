using TaskManagerAPI.Models;

namespace TaskManagerAPI.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsernameAsync(string username);
        Task<User> GetUserByIdAsync(string id);
        Task AddUserAsync(User user);
    }
}
