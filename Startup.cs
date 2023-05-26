using Microsoft.Owin;
using Owin;
//using Swashbuckle.Swagger;

[assembly: OwinStartupAttribute(typeof(vidli.Startup))]
namespace vidli
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);


        }
    }
}