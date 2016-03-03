using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Museu_da_Informática.Startup))]
namespace Museu_da_Informática
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
