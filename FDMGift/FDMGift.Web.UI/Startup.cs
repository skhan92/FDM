using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FDMGift.Web.UI.Startup))]
namespace FDMGift.Web.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
