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
    class Reader : IReader
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
                try
                {
                    reader = new StreamReader(openFileDialog.FileName);
                    numberOfLines = File.ReadAllLines(openFileDialog.FileName).Count();

                    for (int i = 0; i < numberOfLines / 2; i++)
                    {
                        Player player = new PlayerBuilder().setName(reader.ReadLine().ToString()).setPoints(reader.ReadLine().Split(',').Select(Int32.Parse).ToArray()).build();
                        listofPlayers.Add(player);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Logs.saveToLogFile(ex.Message);
                }
            }

            else
            {
                MessageBox.Show("Nie udało się wczytać pliku");
            }
            return listofPlayers;
        }

        private void initializeDialog()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wybierz plik w formacie .txt";
            openFileDialog.Filter = "TXT files|*.txt";
            openFileDialog.InitialDirectory = @"C:\";
        }

        public string readRules(string filepath)
        {
            string txt = "";
            try
            {
                reader = new StreamReader(filepath);
                txt = reader.ReadToEnd();     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logs.saveToLogFile(ex.Message);
            }

            return txt;
        }
    }
}
