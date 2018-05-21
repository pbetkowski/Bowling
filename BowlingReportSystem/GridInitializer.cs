using BowlingReportSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BowlingReportSystem
{
    class GridInitializer
    {
        Game game = new Game();
        public void initializeGrid(DataGridView dataGridView1)
        {
            dataGridView1.ColumnCount = 24;
            dataGridView1.Columns[0].Name = "Zawodnik";
            dataGridView1.Columns[1].Name = "Wynik";

            for (int i = 2; i < 24; i++)
            {
                dataGridView1.Columns[i].Name = (i - 1).ToString();
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        public string[] initializeObjects(Player player, DataGridView dataGridView)
        {   
            string[] arr = new string[dataGridView.ColumnCount];
            arr[0] += player.name;
            arr[1] += game.countPoints(player).ToString();
            for (int i = 0; i < player.points.Length; i++)
            {
                arr[i+2] = player.points[i].ToString();
            }
            return arr;
        }
    }
}
