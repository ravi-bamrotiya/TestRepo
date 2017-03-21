using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureWebAppDemo.Startup))]
namespace AzureWebAppDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
