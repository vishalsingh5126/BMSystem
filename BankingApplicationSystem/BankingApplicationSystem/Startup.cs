using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankingApplicationSystem.Startup))]
namespace BankingApplicationSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
