using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthCareProject.Startup))]
namespace HealthCareProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
