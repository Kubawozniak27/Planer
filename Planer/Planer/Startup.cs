using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Planer.Startup))]
namespace Planer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
