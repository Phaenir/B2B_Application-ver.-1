using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(B2B_Web_Form.Startup))]
namespace B2B_Web_Form
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
