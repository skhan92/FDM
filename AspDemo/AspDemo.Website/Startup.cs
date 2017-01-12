using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspDemo.Website.Startup))]
namespace AspDemo.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
