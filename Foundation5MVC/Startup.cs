using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Foundation5MVC.Startup))]
namespace Foundation5MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
