using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Ninject;

using GDCConsoleApp.Data;
using GDCConsoleApp.Services;

namespace GDCConsoleApp
{
	class Program
	{

		static IKernel Container = new StandardKernel();

		static void Main(string[] args)
		{
			Console.WriteLine("Program is running");

			string filename = "";

			Console.WriteLine("Hello GDC!");

			//Console.WriteLine("Enter CSV Filename including Path");

			//    G:\Projects\GDC\Players.csv
			while (filename == "")
			{
				Console.WriteLine("Enter CSV Filename including Path");
				filename = Console.ReadLine();
			}

			ConfigureContainer();

			WorkerProcess worker = new WorkerProcess(Container.Get<ICSVReader>());

			try
			{
				Console.WriteLine(Environment.NewLine + "Player List:" + Environment.NewLine);	
				worker.LoadPlayers(filename);
			}
			catch (FileNotFoundException)   //Validate File Exists
			{
				Console.WriteLine("The file: '" + filename + "' was not found");
				Console.WriteLine("Press any key to exit...");
				Console.ReadKey();
				return;
			}
			catch (System.Exception)
			{
				Console.WriteLine("The file: '" + filename + "' was not valid");
				Console.WriteLine("Press any key to exit...");
				Console.ReadKey();
				return;
			}

			IEnumerable<Player> players = worker.players;

			players.ToList().ForEach(p => Console.WriteLine(p.FirstName + " " + p.LastName));

			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("Valid player emails...");
			worker.validPlayerEmails.ToList().ForEach(p => Console.WriteLine(p.LastName + " " + p.EmailAddress));

			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("Invalid player emails...");
			worker.invalidPlayerEmails.ToList().ForEach(p => Console.WriteLine(p.LastName + " " + p.EmailAddress));

			Console.WriteLine(Environment.NewLine);
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		private static void ConfigureContainer()
		{
			Container.Bind<ICSVFileLoader>().To<CSVFileLoader>().InSingletonScope();

			Container.Bind<ICSVReader>().To<CSVReader>().InSingletonScope();

			Container.Bind<IEmailService>().To<EmailService>().InSingletonScope();

		}
	}
}
