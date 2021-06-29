using System.Collections.Generic;

using GDCConsoleApp.Data;
using GDCConsoleApp.Services;

namespace GDCConsoleApp.Models
{
    public class PlayerViewModel
    {
        protected ICSVReader DataReader;

        private IEnumerable<Player> _players;
       
        public IEnumerable<Player> Players
        {
            get { return _players; }
            set
            {
                if (_players == value)
                    return;
                _players = value;
                 }
        }

        public PlayerViewModel(ICSVReader dataReader)
        {
            DataReader = dataReader;
        }

        public void RefreshPlayers()
        {
            Players = DataReader.GetPlayers();
        }
        public void ClearPlayers()
        {
            Players = new List<Player>();
        }

        public string DataReaderType
        {
            get { return DataReader.GetType().ToString(); }
        }
    }
}

