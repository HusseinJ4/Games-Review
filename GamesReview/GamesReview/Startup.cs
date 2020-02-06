using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GamesReview.Startup))]
namespace GamesReview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
