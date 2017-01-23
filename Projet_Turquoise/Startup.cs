using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projet_Turquoise.Startup))]
namespace Projet_Turquoise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
