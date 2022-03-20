using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;


[assembly: OwinStartup(typeof(graphASP.NET.Startup))]

namespace graphASP.NET
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
