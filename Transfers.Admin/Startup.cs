using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Transfers.Admin.Startup))]
namespace Transfers.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
