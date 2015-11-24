using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeopleEmpowermentFrontEndSite.Startup))]
namespace PeopleEmpowermentFrontEndSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
