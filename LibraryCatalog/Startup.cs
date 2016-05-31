using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryCatalog.Startup))]
namespace LibraryCatalog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
