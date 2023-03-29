using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MyFirstMvcApp.ModelBinders;

public class DatetimeToYearModelBinderProvider : IModelBinderProvider // "our lower to MVC" 2:23
{
    public IModelBinder? GetBinder(ModelBinderProviderContext context)
    {
        if (context.Metadata.ModelType == typeof(int) && context.Metadata.Name == "Year")
            return new DatetimeToYearModelBinder();

        return null; // "I can not tell, ask the next provider"
    }
}

public class DatetimeToYearModelBinder : IModelBinder
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        var httpYear = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
        if (!DateTime.TryParse(httpYear.FirstValue, out var dateTime))
        {
            bindingContext.Result = ModelBindingResult.Failed();
        }
        bindingContext.Result = ModelBindingResult.Success(dateTime.Year);

        return Task.CompletedTask;
    }
}
