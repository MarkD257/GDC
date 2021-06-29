using System.Collections.Generic;

using GDCConsoleApp.Data;

namespace GDCConsoleApp.Services
{
    public interface ICSVReader
    { 
        string filePath { get; set; }
        IEnumerable<Player> GetPlayers();
    }
}
