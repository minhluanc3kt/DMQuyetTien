using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DMQUYETTIEN.Startup))]
namespace DMQUYETTIEN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
