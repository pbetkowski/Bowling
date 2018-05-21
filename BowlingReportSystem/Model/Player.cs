using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingReportSystem.Model
{
    class Player
    {
        public string name { get; set;}
        public int[] points { get; set;}

        public Player(PlayerBuilder builder)
        {
            this.name = builder.name;
            this.points = builder.points;
        }
    }
}
