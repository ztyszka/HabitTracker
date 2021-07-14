using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HabitTracker.Startup))]
namespace HabitTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
