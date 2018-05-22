using System.Collections.Generic;
using System.Windows.Forms;
using BowlingReportSystem.Model;

namespace BowlingReportSystem.Controler
{
    interface IAppController
    {
        List<Player> fillListOfPlayers();
        void initializeGrid(DataGridView dataGridView);
        string[] initializeRow(Player player, DataGridView dataGridView, RichTextBox textBox);
    }
}