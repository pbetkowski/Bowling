using BowlingReportSystem.Model;


namespace BowlingReportSystem
{
    class Game : IGame
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
                     
                    }

                    else if (player.points[i]+player.points[i+1]==10)
                    {
                        points += player.points[i] + player.points[i + 1] + player.points[i + 2];
                       
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
