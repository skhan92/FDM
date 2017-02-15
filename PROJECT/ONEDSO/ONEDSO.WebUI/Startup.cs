using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ONEDSO.WebUI.Startup))]
namespace ONEDSO.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
