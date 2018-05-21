using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingReportSystem.Model
{
    class PlayerBuilder
    {
        public string name;
        public int[] points;

        public PlayerBuilder setName(string name)
        {
            this.name = name;
            return this;
        }


        public PlayerBuilder setPoints(int[] points)
        {
            this.points = points;
            return this;
        }

        public Player build()
        {
            return new Player(this);
        }

    }
}
