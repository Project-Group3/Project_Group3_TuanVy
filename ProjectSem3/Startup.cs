using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day8_Sercurity.Startup))]
namespace Day8_Sercurity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
