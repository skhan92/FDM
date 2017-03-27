using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSFullStack.Startup))]
namespace PSFullStack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
