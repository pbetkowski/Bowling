using BowlingReportSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowlingReportSystem
{
    class Game
    {
        public int countPoints(Player player)
        {
            int points = 0;
            for (int i = 0; i < player.points.Length; i++)
            {   
                if (i % 2 == 0 && i!=player.points.Length-1)
                {
                    if (player.points[i] == 10)
                    {
                        points += player.points[i] + player.points[i + 2] + player.points[i + 3];
                        MessageBox.Show(player.name + " uzyskał Strike!");
                    }

                    else if (player.points[i]+player.points[i+1]==10 && player.points[i]!=10)
                    {
                        points += player.points[i] + player.points[i + 1] + player.points[i + 2];
                        MessageBox.Show(player.name + " uzyskał Spare!");
                    }

                    else
                    {
                        points += player.points[i] + player.points[i+1];
                    }
                }
            }
            return points;
        }
    }
}
