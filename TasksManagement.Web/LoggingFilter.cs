namespace TasksManagement.Web;


public class LoggingFilter : IEndpointFilter
{
    private ILogger<LoggingFilter> _logger;
    public LoggingFilter(ILogger<LoggingFilter> logger)
    {
        _logger = logger;
    }
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        _logger.LogInformation("Incoming request for {Method} {Path} started at {Time}" , context.HttpContext.Request.Method, context.HttpContext.Request.Path, DateTime.Now);
        
        var response = await next(context);

        _logger.LogInformation("Request {Method} {Path} ended at {Time}", context.HttpContext.Request.Method, context.HttpContext.Request.Path, DateTime.Now);
        return response;
    }
}
