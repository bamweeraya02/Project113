using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookDemo6.Startup))]
namespace BookDemo6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
