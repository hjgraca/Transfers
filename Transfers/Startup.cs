using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Transfers.Startup))]
namespace Transfers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
