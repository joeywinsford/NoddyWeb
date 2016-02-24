using System;
using System.Configuration;
using Microsoft.Owin.Hosting;

namespace NoddyWeb
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = ConfigurationManager.AppSettings["host"];
			string baseUrl = $"http://{host}/";

			using (WebApp.Start<Startup>(new StartOptions(baseUrl) { ServerFactory = "Microsoft.Owin.Host.HttpListener" }))
			{
				Console.WriteLine("Started, Press Return key to stop.");
				Console.ReadLine();
				Console.WriteLine("Stopped");
			}
		}
	}
}
