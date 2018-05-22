using BowlingReportSystem.Model;
using System.Windows.Forms;

namespace BowlingReportSystem
{
    interface IGame
    {
       int countPoints(Player player, RichTextBox textBox);
    }
}