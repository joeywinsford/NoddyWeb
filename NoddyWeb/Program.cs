using System;
using Microsoft.Owin.Hosting;

namespace NoddyWeb
{
	public class Program
	{
		public static void Main(string[] args)
		{
			const string baseUrl = "http://localhost:12345/";

			using (WebApp.Start<Startup>(new StartOptions(baseUrl) { ServerFactory = "Microsoft.Owin.Host.HttpListener" }))
			{
				Console.WriteLine("Started, Press Return key to stop.");
				Console.ReadLine();
				Console.WriteLine("Stopped");
			}
		}
	}
}
