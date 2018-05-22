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
      

        public AppController()
        {
            this.reader = new Reader();
            this.gridInitializer = new GridInitializer();
          
        }

        public void initializeGrid(DataGridView dataGridView)
        {
            this.gridInitializer.initializeGrid(dataGridView);
        }

        public List<Player> fillListOfPlayers()
        {
            return this.reader.FillListOfPlayers();
        }

        public String[] initializeRow(Player player, DataGridView dataGridView)
        {
            return this.gridInitializer.initializeObjects(player, dataGridView);
        }

    }
}
