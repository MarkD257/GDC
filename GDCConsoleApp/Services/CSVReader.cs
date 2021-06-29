using System;
using System.Collections.Generic;

using GDCConsoleApp.Data;

namespace GDCConsoleApp.Services
{
    public class CSVReader : ICSVReader
    {
        public ICSVFileLoader fileLoader { get; set; }
        public string filePath { get; set; }

		public CSVReader()
		{
            //this.filePath = filePath;
            ////string filePath = AppCurrentBaseDirectory + "players.txt";
            //fileLoader = new CSVFileLoader(filePath);
        }

		public IEnumerable<Player> GetPlayers()
        {
            fileLoader = new CSVFileLoader(filePath);   //should not new up -- should  set as property 
            var fileData = fileLoader.LoadFile();
            var players = ParseDataString(fileData);
            return players;
        }

        private IEnumerable<Player> ParseDataString(string csvData)
        {
            var players = new List<Player>();
            var lines = csvData.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (string line in lines)
            {
                try
                {
                    players.Add(ParsePlayerString(line));
                }
                catch (Exception)
                {
                    // Skip the bad record, log it, and move to the next record
                    // log.Write($"Unable to parse record: {line}")
                }
            }
            return players;
        }

        private Player ParsePlayerString(string PlayerData)
        {
            var elements = PlayerData.Split(',');
            var Player = new Player()
            {
                FirstName = elements[0],
                LastName = elements[1],
                EmailAddress = elements[2]
            };
            return Player;
        }
    }
}
