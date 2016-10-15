using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Groupware.AdventureWoks.Demo.Startup))]
namespace Groupware.AdventureWoks.Demo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
