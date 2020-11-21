
using Microsoft.Extensions.DependencyInjection;
using Owin;

namespace MGRescue_System
{
    public partial class Startup
    {
        
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
        }

    }
}
