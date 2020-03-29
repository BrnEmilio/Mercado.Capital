using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Mercado.Capital.Cotacao.App_Start.Startup))]

namespace Mercado.Capital.Cotacao.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}