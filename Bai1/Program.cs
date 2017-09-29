using System;
using System.Net;

namespace Bai1
{
	class Program
	{
		static void Main(string[] args)
		{
			IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (IPAddress ip in host.AddressList)
			{
				Console.WriteLine(ip.ToString());
			}
			Console.ReadKey();
		}
	}
}
