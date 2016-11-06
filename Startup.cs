using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcEducation.Startup))]
namespace MvcEducation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
