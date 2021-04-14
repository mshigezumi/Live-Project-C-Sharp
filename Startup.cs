using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.Identity;
using TheatreCMS3.Models;
using TheatreCMS3.Areas.Blog.Models;

[assembly: OwinStartupAttribute(typeof(TheatreCMS3.Startup))]
namespace TheatreCMS3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app, UserManager<PostMaster> userManager)
        {
            ConfigureAuth(app);
            PostMaster.Seed(userManager);
        }
    }
}
