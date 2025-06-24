using TaskManagerAPI.Models;

namespace TaskManagerAPI.Repositories
{
    public interface ITaskRepository
    {
        Task<IEnumerable<TaskItem>> GetTasksAsync(string userId);
        Task<TaskItem> CreateTaskAsync(TaskItem task);
        Task<TaskItem> GetTaskByIdAsync(int id);
        Task<bool> UpdateTaskAsync(TaskItem task);
        Task<bool> DeleteTaskAsync(TaskItem task);
    }
}