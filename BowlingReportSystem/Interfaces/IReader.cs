using System.Collections.Generic;
using BowlingReportSystem.Model;

namespace BowlingReportSystem.Files
{
    interface IReader
    {
        List<Player> FillListOfPlayers();
    }
}