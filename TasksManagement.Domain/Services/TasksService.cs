using TasksManagement.Domain.Interfaces;
using TasksManagement.Domain.Models;

namespace TasksManagement.Domain.Services;

public class TasksService : ITasksService
{
    ITaskRepository _taskRepository;
    public TasksService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<Result<ManagedTask>> Create(ManagedTask task)
    {
        if (task.Id != 0 || task == null) // Id = 0 means that the task is new
        {
            return null; // Todo implement return error
        }
        try
        {
            task.CreatedAt = DateTime.Now;
            var result = new Result<ManagedTask>() { Data = task };
            return await _taskRepository.Create(task);
        }
         catch (Exception e)
        {
            return null;
        }

    }

    public Task<Result<List<ManagedTask>>> Get(ManagedTaskStatus status)
    {
        throw new NotImplementedException();
    }

    public Task<Result<ManagedTask>> GetById(int id)
    {
        throw new NotImplementedException();
    }
}
