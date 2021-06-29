using System.Collections.Generic;
using System.Linq;

using GDCConsoleApp.Data;
using GDCConsoleApp.Services;

namespace GDCConsoleApp
{
    public class WorkerProcess
    {
        private readonly ICSVReader dataReader;


        public IEnumerable<Player> players;

        public List<Player> validPlayerEmails;
        public List<Player> invalidPlayerEmails;

        public WorkerProcess(ICSVReader dataReader)
        {
            this.dataReader = dataReader;
        }

        public void LoadPlayers(string fileName)
        {
            try
            {
                this.dataReader.filePath = fileName;
                players = dataReader.GetPlayers();

                validPlayerEmails = players.Where(p => RegexUtilities.IsValidEmail(p.EmailAddress) == true).ToList();
                invalidPlayerEmails = players.Where(p => RegexUtilities.IsValidEmail(p.EmailAddress) == false).ToList();

            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public string DataReaderType
        {
            get { return dataReader.GetType().ToString(); }
        }
    }
}
