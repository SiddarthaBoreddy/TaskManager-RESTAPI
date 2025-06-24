using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Data;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddUserAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetUserByIdAsync(string id) =>
            await _context.Users.FindAsync(id);

        public async Task<User> GetUserByUsernameAsync(string username) =>
            await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
    }
}