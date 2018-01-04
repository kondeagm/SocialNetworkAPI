using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialNetworkAPI.Startup))]
namespace SocialNetworkAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
