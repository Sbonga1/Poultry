using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Poultry_Management_System.Startup))]
namespace Poultry_Management_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
