using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GithubSuperDemo.Startup))]
namespace GithubSuperDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
