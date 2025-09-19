using TasksManagement.Domain.Interfaces;
using TasksManagement.Domain.Models;

namespace TasksManagement.Data;

public class TaskRepository : ITaskRepository
{
    //TODO: Implement the repository as In-Memory data layer
    public List<ManagedTask> TaskList = new List<ManagedTask>();
    
    public TaskRepository() { }
    public Task<Result<ManagedTask>> Create(ManagedTask task)
    {
        try
        {
            task.Id = TaskList.Count + 1; // Simulate auto-incrementing primary key
            TaskList.Add(task);
            var result = new Result<ManagedTask>() { Data = task};
            return Task.FromResult(result);

        } catch (Exception e)
        {
            var result = new Result<ManagedTask>() { Data = task, ErrorCode = ErrorCode.NotFound, ErrorDescription = "Failed to add task to database" };
            return Task.FromResult(result);
        }
    }

    public Task<Result<List<ManagedTask>>> Get(ManagedTaskStatus? status)
    {
        try
        { 
            if (status == null)
            {
                // Return all in case of null
                return Task.FromResult(new Result<List<ManagedTask>>() { Data = TaskList });
            }
            var filteredTasks = TaskList.Where(t => t.Status == status).ToList();
            var result = new Result<List<ManagedTask>>() { Data = filteredTasks };
            return Task.FromResult(result); 
        }
        catch (Exception e)
        {
            var result = new Result<List<ManagedTask>>() { Data = null, ErrorCode = ErrorCode.NotFound, ErrorDescription = "Failed to retrieve tasks from database" };
            return Task.FromResult(result);
        }
    }

    public Task<Result<ManagedTask>> GetById(int id)
    {
        try
        {
            var task = TaskList.Find(t => t.Id == id);
            if (task == null)
            {
                return Task.FromResult(new Result<ManagedTask>() { Data = null, ErrorCode = ErrorCode.NotFound, ErrorDescription = $"Task with id {id} not found" });
            }

            return Task.FromResult(new Result<ManagedTask>() { Data = task });

        }
        catch (Exception e)
        {
            var result = new Result<ManagedTask>() { Data = null, ErrorCode = ErrorCode.NotFound, ErrorDescription = "Failed to retrieve task from database" };
            return Task.FromResult(result);
        }
    }
}
