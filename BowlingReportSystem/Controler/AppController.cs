using BowlingReportSystem.Files;
using BowlingReportSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowlingReportSystem.Controler
{
    class AppController : IAppController
    {
        private Reader reader;
        private GridInitializer gridInitializer;
        private Game game;

        public AppController()
        {
            this.reader = new Reader();
            this.gridInitializer = new GridInitializer();
            this.game = new Game();
          
        }

        public void initializeGrid(DataGridView dataGridView)
        {
            this.gridInitializer.initializeGrid(dataGridView);
        }

        public List<Player> fillListOfPlayers()
        {
            return this.reader.FillListOfPlayers();
        }

        public String[] initializeRow(Player player, DataGridView dataGridView, RichTextBox textBox)
        {
            return this.gridInitializer.initializeObjects(player, dataGridView, textBox);
        }

        public String readRules(string filepath)
        {
            return this.reader.readRules(filepath);
        }


        public String getWinner(List<Player> listOfPlayers, RichTextBox textBox)
        {
            return this.game.findWinner(listOfPlayers, textBox);
        }

    }
}
