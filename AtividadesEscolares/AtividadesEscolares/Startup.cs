using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AtividadesEscolares.Startup))]
namespace AtividadesEscolares
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
