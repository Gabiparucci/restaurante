using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestauranteAnte.Startup))]
namespace RestauranteAnte
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
