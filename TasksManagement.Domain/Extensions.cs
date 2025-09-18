using Microsoft.Extensions.DependencyInjection;
using TasksManagement.Domain.Interfaces;
using TasksManagement.Domain.Models;
using TasksManagement.Domain.Services;

namespace TasksManagement.Domain;
public static class Extensions
{
    public static IServiceCollection AddServices(this IServiceCollection service)
    {
        service.AddScoped<ITasksService, TasksService>();
        return service;
    }
}
