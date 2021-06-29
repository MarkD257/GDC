using System.IO;

namespace GDCConsoleApp.Services
{
    public class CSVFileLoader : ICSVFileLoader
    {
		private readonly string _filePath;

		public CSVFileLoader(string filePath)
		{
			_filePath = filePath.Trim();
		}

		public string LoadFile()
        {
			using var reader = new StreamReader(_filePath);

			return reader.ReadToEnd();
		}
    }
}
