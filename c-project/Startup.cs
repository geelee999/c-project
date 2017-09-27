using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(c_project.Startup))]
namespace c_project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
