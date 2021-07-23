using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASp.NETWebApplication_.NETFrameworkEntityFramework.Startup))]
namespace ASp.NETWebApplication_.NETFrameworkEntityFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
