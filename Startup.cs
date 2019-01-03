using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Emp_Mvc.Startup))]
namespace Emp_Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
