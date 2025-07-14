using Microsoft.Extensions.DependencyInjection;
using TasksManagement.Domain.Services;

namespace TasksManagement.Domain;
public static class Extensions
{
    public static IServiceCollection AddServices(this IServiceCollection service)
    {
        //TODO: Add services to DI container

        return service;
    }
}
