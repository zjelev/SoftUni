namespace SIS.MvcFramework.Tests;

public class ViewEngineTests
{
    [Theory]
    [InlineData("OnlyHtmlView")]
    [InlineData("ForForeachIfView")]
    [InlineData("ViewModelView")]
    public void TestGetHtml(string testName, string user)
    {
        var viewModel = new TestViewModel()
        {
            Name = "Niki",
            Year = 2022,
            Numbers = new List<int> { 1, 10, 100, 1000, 10000 }
        };

        var viewContent = File.ReadAllText($"../../../ViewTests/{testName}.html");
        var expectedResultContent = File.ReadAllText($"../../../ViewTests/{testName}.Expected.html");

        IViewEngine viewEngine = new ViewEngine();
        var actualResult = viewEngine.GetHtml(viewContent, viewModel, "123");

        Assert.Equal(expectedResultContent, actualResult);
    }

    [Fact]
    public void TestGetHtmlWithTemplateModel(string user)
        {
            var viewModel = new List<int> { 1, 2, 3 };

            var viewContent = @"
@foreach (var num in Model)
{
<p>@num</p>
}";
            var expectedResultContent = @"
<p>1</p>
<p>2</p>
<p>3</p>
";

            IViewEngine viewEngine = new ViewEngine();
            var actualResult = viewEngine.GetHtml(viewContent, viewModel, null);

            Assert.Equal(expectedResultContent, actualResult);
        }
}