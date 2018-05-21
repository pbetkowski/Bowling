using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using BowlingReportSystem.Model;

namespace BowlingReportSystem.Files
{
    class Reader 
    {
        StreamReader reader = null;
        OpenFileDialog openFileDialog;
        int numberOfLines;

        public List<Player> FillListOfPlayers()
        {
            initializeDialog();
            List<Player> listofPlayers = new List<Player>();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                reader = new StreamReader(openFileDialog.FileName);
                numberOfLines = File.ReadAllLines(openFileDialog.FileName).Count();

                for (int i = 0; i < numberOfLines / 2; i++)
                {
                    Player player = new PlayerBuilder().setName(reader.ReadLine().ToString()).setPoints(reader.ReadLine().Split(',').Select(Int32.Parse).ToArray()).build();
                    listofPlayers.Add(player);
                }
            }
            return listofPlayers;
        }

        private void initializeDialog()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Choose an appropriate .txt file.";
            openFileDialog.Filter = "TXT files|*.txt";
            openFileDialog.InitialDirectory = @"C:\";
        }
    }
}
