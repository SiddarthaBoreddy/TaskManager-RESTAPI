using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Data;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context;

        public TaskRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TaskItem>> GetTasksAsync(string userId) =>
            await _context.Tasks.Where(t => t.UserId == userId).ToListAsync();

        public async Task<TaskItem> CreateTaskAsync(TaskItem task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<TaskItem> GetTaskByIdAsync(int id) =>
            await _context.Tasks.FindAsync(id);

        public async Task<bool> UpdateTaskAsync(TaskItem task)
        {
            _context.Tasks.Update(task);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteTaskAsync(TaskItem task)
        {
            _context.Tasks.Remove(task);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}