using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParasharGitWebsite.Startup))]
namespace ParasharGitWebsite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
