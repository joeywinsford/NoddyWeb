using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace NoddyWeb
{
    public class Startup
    {
	    public void Configuration(IAppBuilder app)
	    {
		    app.Run(Invoke);
	    }

	    public Task Invoke(IOwinContext context)
	    {
		    context.Response.ContentType = "text/plain";
		    return context.Response.WriteAsync(DateTime.Now.ToString(CultureInfo.CurrentCulture));
	    }
    }
}
