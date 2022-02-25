using System;
using System.Threading.Tasks;
using Devlead.Statiq.Themes;
using Statiq.App;
using Statiq.Web;

static class Program
{
    static async Task Main(string[] args) =>
        await Bootstrapper
            .Factory
            .CreateDefault(args)
            .AddThemeFromUri(new Uri("https://github.com/statiqdev/CleanBlog/archive/71b37ce47fd5b47dbc993e7591ef8cda6c930e44.zip"))
            .AddWeb()
            .RunAsync();
}