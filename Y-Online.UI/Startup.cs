using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Y_Online.UI.Startup))]
namespace Y_Online.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
