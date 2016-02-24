using System.Threading.Tasks;
using Microsoft.Owin;

namespace NoddyWeb.Responses
{
	public interface IAppResponse
	{
		bool MatchesRequest(IOwinRequest request);
		Task Respond(IOwinResponse response);
	}
}