using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InfrastructureNetFramework.Startup))]
namespace InfrastructureNetFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
