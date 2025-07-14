namespace TasksManagement.Web;


public class LoggingFilter : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        //TODO: Implement logging filter
        
        var response = await next(context);

        return response;
    }
}
