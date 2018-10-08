using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nhom1_quanlybanhang.Startup))]
namespace nhom1_quanlybanhang
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
