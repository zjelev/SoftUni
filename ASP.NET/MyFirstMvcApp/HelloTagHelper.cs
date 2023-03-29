using Microsoft.AspNetCore.Razor.TagHelpers;
using MyFirstMvcApp.Services;

namespace MyFirstMvcApp
{
    [HtmlTargetElement("h1", Attributes = "greeting-name"), HtmlTargetElement("h2")]
    public class HelloTagHelper : TagHelper
    {
        private readonly IUsersService usersService;

        public HelloTagHelper(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public string GreetingName { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("Niki", GreetingName);
            output.Content.SetContent(GreetingName);
            output.PreElement.SetContent(GreetingName);
            output.PostElement.SetContent(this.usersService.GetCount().ToString());
        }
    }
}
