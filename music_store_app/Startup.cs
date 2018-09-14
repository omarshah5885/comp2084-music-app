using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(music_store_app.Startup))]
namespace music_store_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
