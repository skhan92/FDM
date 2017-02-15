using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ONEDSO.Web.UI.Startup))]
namespace ONEDSO.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
