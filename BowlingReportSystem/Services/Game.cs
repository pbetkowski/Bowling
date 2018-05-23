using BowlingReportSystem.Model;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BowlingReportSystem
{
    public class Game : IGame
    {
        public int countPoints(Player player, RichTextBox textBox)
        {
            int points = 0;
            for (int i = 0; i < player.points.Length; i++)
            {   
                if (i % 2 == 0 && i!=player.points.Length-1)
                {
                    if (player.points[i] == 10)
                    {
                        points += player.points[i] + player.points[i + 2] + player.points[i + 3];
                        textBox.AppendText(player.name + " zdobywa strike!" + "\n");
                     
                    }

                    else if (player.points[i]+player.points[i+1]==10)
                    {
                        points += player.points[i] + player.points[i + 1] + player.points[i + 2];
                        textBox.AppendText(player.name + " zdobywa spare !" + "\n");
                    }

                    else
                    {
                        points += player.points[i] + player.points[i+1];
                        textBox.AppendText(player.name + " zdobywa " + (player.points[i] + player.points[i+1]).ToString() + " punktow." +"\n");
                    }
                }
            }
            return points;
        }

        public string findWinner(List<Player> listOfPlayers, RichTextBox textBox)
        {

            string winner = "";

            for (int i = 1; i < listOfPlayers.Count; i++)
            {
                winner = listOfPlayers[i].name;
                if (countPoints(listOfPlayers[i], textBox) > countPoints(listOfPlayers[i - 1], textBox))
                {
                    winner = listOfPlayers[i].name;
                }
            }

            MessageBox.Show("Zwyciezyl " + winner);
            textBox.AppendText("Koniec gry. Zwyciezyl "+ winner);
            return winner;
        }
    }
}
