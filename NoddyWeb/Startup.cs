using Owin;

namespace NoddyWeb
{
    public class Startup
    {
	    public void Configuration(IAppBuilder app)
	    {
			app.Run(App.HandleRequest);
	    }
    }
}
