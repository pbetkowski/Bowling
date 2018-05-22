using BowlingReportSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BowlingReportSystem
{
    class GridInitializer : IGridInitializer
    {
        Game game = new Game();
        public void initializeGrid(DataGridView dataGridView1)
        {
            try
            {
                dataGridView1.ColumnCount = 24;
                dataGridView1.Columns[0].Name = "Zawodnik";
                dataGridView1.Columns[1].Name = "Wynik";

                for (int i = 0; i < 2; i++)
                {
                    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                for (int i = 2; i < 24; i++)
                {
                    dataGridView1.Columns[i].Name = (i - 1).ToString();
                    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            catch (Exception e)
            {

                Logs.saveToLogFile(e.Message);
            }
        }

        public string[] initializeObjects(Player player, DataGridView dataGridView, RichTextBox textBox)
        {
            string[] arr = new string[dataGridView.ColumnCount];
            try
            {
                
                arr[0] += player.name;
                arr[1] += game.countPoints(player, textBox).ToString();
                for (int i = 0; i < player.points.Length; i++)
                {
                    arr[i + 2] = player.points[i].ToString();
                }
            }
            catch (Exception e)
            {
                Logs.saveToLogFile(e.Message);
            }
            return arr;
        }
    }
}
