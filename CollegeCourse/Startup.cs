using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollegeCourse.Startup))]
namespace CollegeCourse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
