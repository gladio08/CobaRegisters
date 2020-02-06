using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CobaRegister.Startup))]
namespace CobaRegister
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
