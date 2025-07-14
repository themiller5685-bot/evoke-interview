using TasksManagement.Domain.Interfaces;
using TasksManagement.Domain.Models;

namespace TasksManagement.Domain.Services;

public class TasksService : ITasksService
{
    //TODO: implement TasksService

    public Task<Result<ManagedTask>> Create(ManagedTask task)
    {
        throw new NotImplementedException();
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
