using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp_email_activ.Startup))]
namespace asp_email_activ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
