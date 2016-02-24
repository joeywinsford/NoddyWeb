using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace NoddyWeb.Responses
{
	public class NowResponse : IAppResponse
	{
		public bool MatchesRequest(IOwinRequest request)
		{
			return true;
		}

		public Task Respond(IOwinResponse response)
		{
			response.ContentType = "text/plain";
			return response.WriteAsync(DateTime.Now.ToString(CultureInfo.CurrentCulture));
		}
	}
}