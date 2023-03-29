﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using MyFirstMvcApp.Services;

namespace MyFirstMvcApp.Filters;

public class MyAuthorizeFilterAttribute : Attribute, IAuthorizationFilter
{
    private readonly IUsersService usersService;

    public MyAuthorizeFilterAttribute(IUsersService usersService)
    {
        this.usersService = usersService;
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
    }
}

public class MyResourceFilter : IResourceFilter
{
    public void OnResourceExecuted(ResourceExecutedContext context)
    {
    }

    public void OnResourceExecuting(ResourceExecutingContext context)
    {
    }
}

public class MyResultFilter : IResultFilter
{
    public void OnResultExecuted(ResultExecutedContext context)
    {
    }

    public void OnResultExecuting(ResultExecutingContext context)
    {
    }
}

public class MyExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
    }
}

public class ValidateModelStateFilterAttribute : Attribute, IActionFilter
{
    public void OnActionExecuting(ActionExecutingContext context)
    {
        //if (!context.ModelState.IsValid)
        //    context.Result = new ContentResult() { Content = "Invalid model state" };
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        //context.Result = new JsonResult("Valid Model State");
    }
}

public class AddHeaderAttribute : Attribute, IAsyncActionFilter, IAsyncPageFilter
{
    private readonly string header;
    private readonly string value;

    public AddHeaderAttribute(string header, string value)
    {
        this.header = header;
        this.value = value;
    }

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        context.HttpContext.Response.Headers.Add(header, value);
        await next();
    }

    public async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
    {
        context.HttpContext.Response.Headers.Add(header, value);
        await next();
    }

    public Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
    {
        return Task.CompletedTask;
    }
}