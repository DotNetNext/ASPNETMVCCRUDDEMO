using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BBS.Startup))]
namespace BBS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
