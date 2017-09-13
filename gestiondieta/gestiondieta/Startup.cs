using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gestiondieta.Startup))]
namespace gestiondieta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
