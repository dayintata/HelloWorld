using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HELLOWORLD.Startup))]
namespace HELLOWORLD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
