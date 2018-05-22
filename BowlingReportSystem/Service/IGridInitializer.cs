using System.Windows.Forms;
using BowlingReportSystem.Model;

namespace BowlingReportSystem
{
    interface IGridInitializer
    {
        void initializeGrid(DataGridView dataGridView1);
        string[] initializeObjects(Player player, DataGridView dataGridView);
    }
}