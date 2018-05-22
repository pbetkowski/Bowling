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
            int[] points = { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2};
            int expected = 30;
            int actual;
            Player player = new PlayerBuilder().setName("Jan Nowak").setPoints(points).build();
            RichTextBox textBox = new RichTextBox();
            Game game = new Game();
            actual = game.countPoints(player,textBox);
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
    }
}