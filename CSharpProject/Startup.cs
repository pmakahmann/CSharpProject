using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CSharpProject.Startup))]
namespace CSharpProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
