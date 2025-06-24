using TaskManagerAPI.DTOs;
using TaskManagerAPI.Models;

namespace TaskManagerAPI.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskItem>> GetTasksAsync(string userId);
        Task<TaskItem> CreateTaskAsync(string userId, TaskItemDto dto);
        Task<bool> UpdateTaskAsync(string userId, int id, TaskItemDto dto);
        Task<bool> DeleteTaskAsync(string userId, int id);
    }
}