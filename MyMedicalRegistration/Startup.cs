using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMedicalRegistration.Startup))]
namespace MyMedicalRegistration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
