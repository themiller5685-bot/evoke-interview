using Microsoft.Extensions.DependencyInjection;
using TasksManagement.Domain.Interfaces;

namespace TasksManagement.Data;
public static class Extensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection service)
    {
        //TODO: Add repositories to DI container
        service.AddSingleton<ITaskRepository, TaskRepository>();
        return service;
    }
}
