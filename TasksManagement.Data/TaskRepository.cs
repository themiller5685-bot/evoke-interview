using TasksManagement.Domain.Interfaces;
using TasksManagement.Domain.Models;

namespace TasksManagement.Data;

public class TaskRepository : ITaskRepository
{
    //TODO: Implement the repository as In-Memory data layer
    
    public Task<Result<ManagedTask>> Create(ManagedTask task)
    {
        throw new NotImplementedException();
    }

    public Task<Result<List<ManagedTask>>> Get(ManagedTaskStatus? status)
    {
        throw new NotImplementedException();
    }

    public Task<Result<ManagedTask>> GetById(int id)
    {
        throw new NotImplementedException();
    }
}
