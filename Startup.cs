using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JesseCannon_Assignment1.Startup))]
namespace JesseCannon_Assignment1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
