using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Initialise.Startup))]
namespace Initialise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
