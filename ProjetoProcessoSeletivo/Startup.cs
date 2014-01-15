using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoProcessoSeletivo.Startup))]
namespace ProjetoProcessoSeletivo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
