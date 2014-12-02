using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(动态网页.Startup))]
namespace 动态网页
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
