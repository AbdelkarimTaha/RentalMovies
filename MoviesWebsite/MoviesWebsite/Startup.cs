using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesWebsite.Startup))]
namespace MoviesWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
