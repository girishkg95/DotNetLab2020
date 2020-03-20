using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleMVC5WebApplication.Startup))]
namespace SampleMVC5WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
