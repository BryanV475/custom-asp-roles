using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Registro.Startup))]
namespace Registro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
