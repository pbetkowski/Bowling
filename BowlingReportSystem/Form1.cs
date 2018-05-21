using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using BowlingReportSystem.Files;
using BowlingReportSystem.Model;

namespace BowlingReportSystem
{
    public partial class Form1 : Form
    {
        Reader reader = new Reader();
        List<Player> listOfPlayers;
        GridInitializer gridInitializer = new GridInitializer();

        public Form1()
        {
            InitializeComponent();
            gridInitializer.initializeGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listOfPlayers = reader.FillListOfPlayers();
           
            foreach (Player player in listOfPlayers)
            {
                string[] row = gridInitializer.initializeObjects(player, dataGridView1);
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
