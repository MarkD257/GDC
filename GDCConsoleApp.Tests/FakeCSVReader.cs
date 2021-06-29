using System.Collections.Generic;

using GDCConsoleApp.Data;
using GDCConsoleApp.Services;


namespace GDCConsoleApp.Tests
{

    public class FakeReader : ICSVReader
    {
        readonly List<Player>  testData = new List<Player>()
        {
            new Player() {FirstName = "Bryce",  LastName = "Harper", EmailAddress = "BryceHarper@phillies.com"},
            new Player() {FirstName = "Aaron",  LastName = "Nola", EmailAddress = " Aaron Nola@phillies.com"},
        };

		public string filePath { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

		public IEnumerable<Player> GetPlayers()
        {
            return testData;
        }
    }

}
