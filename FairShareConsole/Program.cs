using FairShare;
using System;

namespace FairShareConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			var fs = FairShare.FairShare.Get(3, 9);
			Console.WriteLine(fs);
			Console.ReadLine();
		}
	}
}
