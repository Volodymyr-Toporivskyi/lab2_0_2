using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab2_0_2.Startup))]
namespace lab2_0_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
