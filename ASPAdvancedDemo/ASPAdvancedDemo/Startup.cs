using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPAdvancedDemo.Startup))]
namespace ASPAdvancedDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
