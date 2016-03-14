using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Escola.UI.MVC.Startup))]
namespace Escola.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
