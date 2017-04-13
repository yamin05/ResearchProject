using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResearchProject.Startup))]
namespace ResearchProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
