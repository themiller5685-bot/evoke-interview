namespace TasksManagement.Web;


public class LoggingFilter : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        //TODO: Implement loggin filter
        
        var response = await next(context);

        return response;
    }
}
