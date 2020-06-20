using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Battalion.Startup))]
namespace Battalion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
