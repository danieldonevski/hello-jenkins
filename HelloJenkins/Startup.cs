using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloJenkins.Startup))]
namespace HelloJenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
