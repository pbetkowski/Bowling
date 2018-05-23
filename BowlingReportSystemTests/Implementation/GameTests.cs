using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingReportSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingReportSystem.Model;
using System.Windows.Forms;

namespace BowlingReportSystem.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void countPointsTest()
        {
            int[] points = { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            int expected = 30;
            int actual;
            Player player = new PlayerBuilder().setName("Jan Nowak").setPoints(points).build();
            RichTextBox textBox = new RichTextBox();
            Game game = new Game();
            actual = game.countPoints(player, textBox);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Strike()
        {
            int[] points = { 10, 0, 2, 5, 5, 5, 4, 1, 10 };
            int expected = 43;
            int actual;
            Player player = new PlayerBuilder().setName("Jan Nowak").setPoints(points).build();
            RichTextBox textBox = new RichTextBox();
            Game game = new Game();
            actual = game.countPoints(player, textBox);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Spare()
        {
            int[] points = { 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 9 };
            int expected = 118;
            int actual;
            Player player = new PlayerBuilder().setName("Jan Nowak").setPoints(points).build();
            RichTextBox textBox = new RichTextBox();
            Game game = new Game();
            actual = game.countPoints(player, textBox);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void findWinnerTest()
        {
            Game game = new Game();
            RichTextBox textBox = new RichTextBox();
            int[] points1 = { 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 9 };
            int[] points2 = { 10, 0, 10, 0, 10, 0, 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 1, 9, 1 };
            Player player1 = new PlayerBuilder().setName("Jan Nowak").setPoints(points1).build();
            Player player2 = new PlayerBuilder().setName("Jan Kowalski").setPoints(points2).build();
            List<Player> list = new List<Player>();
            list.Add(player1);
            list.Add(player2);

            String expected = player2.name;
            String actual = game.findWinner(list, textBox);
            Assert.AreEqual(expected, actual);
        }
    }
}