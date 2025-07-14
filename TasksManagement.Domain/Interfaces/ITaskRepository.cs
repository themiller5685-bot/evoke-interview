using TasksManagement.Domain.Models;

namespace TasksManagement.Domain.Interfaces;

public interface ITaskRepository
{
    Task<Result<ManagedTask>> GetById(int id);

    Task<Result<List<ManagedTask>>> Get(ManagedTaskStatus? status);

    Task<Result<ManagedTask>> Create(ManagedTask task);
}
