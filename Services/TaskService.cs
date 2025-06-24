using TaskManagerAPI.DTOs;
using TaskManagerAPI.Models;
using TaskManagerAPI.Repositories;

namespace TaskManagerAPI.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepo;
        public TaskService(ITaskRepository taskRepo) { _taskRepo = taskRepo; }

        public async Task<IEnumerable<TaskItem>> GetTasksAsync(string userId) =>
            await _taskRepo.GetTasksAsync(userId);

        public async Task<TaskItem> CreateTaskAsync(string userId, TaskItemDto dto)
        {
            var task = new TaskItem
            {
                Title = dto.Title,
                Description = dto.Description,
                IsComplete = dto.IsComplete,
                UserId = userId
            };
            return await _taskRepo.CreateTaskAsync(task);
        }

        public async Task<bool> UpdateTaskAsync(string userId, int id, TaskItemDto dto)
        {
            var task = await _taskRepo.GetTaskByIdAsync(id);
            if (task == null || task.UserId != userId) return false;
            task.Title = dto.Title;
            task.Description = dto.Description;
            task.IsComplete = dto.IsComplete;
            return await _taskRepo.UpdateTaskAsync(task);
        }

        public async Task<bool> DeleteTaskAsync(string userId, int id)
        {
            var task = await _taskRepo.GetTaskByIdAsync(id);
            if (task == null || task.UserId != userId) return false;
            return await _taskRepo.DeleteTaskAsync(task);
        }
    }
}