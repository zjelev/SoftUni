using Microsoft.AspNetCore.Mvc.Filters;

namespace Eventures.Filters;

public class AdminActivityLoggerFilter : IActionFilter
{
    private readonly ILogger<AdminActivityLoggerFilter> logger;

    public AdminActivityLoggerFilter(ILogger<AdminActivityLoggerFilter> logger)
    {
        this.logger = logger;
    }
    public void OnActionExecuted(ActionExecutedContext context)
    {
        if (context.ActionDescriptor.DisplayName.Contains("EventsController") &&
            context.ActionDescriptor.DisplayName.Contains("Create"))
        {
            this.logger.LogInformation("   ### Create page accessed at {DT}", DateTime.UtcNow.ToString());
        }
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
    }
}

