using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieCentralOne.Startup))]
namespace MovieCentralOne
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
