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
using BowlingReportSystem.Model;
using BowlingReportSystem.Controler;

namespace BowlingReportSystem
{
    public partial class Form1 : Form
    {
        List<Player> listOfPlayers;
        AppController app = new AppController();
        Dictionary<string, int> map = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            app.initializeGrid(dataGridView1);
            pictureBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            listOfPlayers = app.fillListOfPlayers();

            foreach (Player player in listOfPlayers)
            {
                string[] row = app.initializeRow(player, dataGridView1, richTextBox1);
                dataGridView1.Rows.Add(row);
            }
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            app.getWinner(listOfPlayers, richTextBox1);
        }

    }
}
