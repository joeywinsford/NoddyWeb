using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Owin;
using NoddyWeb.Responses;

namespace NoddyWeb
{
	public static class App
	{
		private static readonly List<IAppResponse> Responses = new List<IAppResponse> {
			new NowResponse()
		};

		public static Task HandleRequest(IOwinContext context)
		{
			var response = Responses.First(r => r.MatchesRequest(context.Request));
			return response.Respond(context.Response);
		}
	}
}