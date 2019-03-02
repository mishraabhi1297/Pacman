using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacman;

namespace PacmanUnitTesting
{
    [TestClass]
    public class DirectionCommandTesting
    {
        [TestMethod]
        public void LeftCommandSuccessful()
        {
            //Arrange
            GameManager.Pac = new Pacman.Pacman(2,2,"NORTH");
            LeftCommand lc = new LeftCommand();
            ReportCommand rc = new ReportCommand();
            String input = "LEFT";
            lc.execute(input);

            //Assert
            Assert.AreEqual(rc.execute("REPORT"), "Output: 2,2,WEST");
        }

        [TestMethod]
        public void LeftCommandWrongParams()
        {
            //Arrange
            GameManager.Pac = new Pacman.Pacman(2, 2, "NORTH");
            LeftCommand lc = new LeftCommand();
            String input = "LEFT JOIN";

            //Assert
            Assert.AreEqual(lc.execute(input), "'LEFT' command does not need any parameters");
        }

        [TestMethod]
        public void LeftCommandUnsuccessful()
        {
            //Arrange
            GameManager.Pac = null;
            LeftCommand lc = new LeftCommand();
            String input = "";

            //Assert
            Assert.AreEqual(lc.execute(input), "Make sure the Pacman is placed on the grid before you can rotate or move it");
        }

        [TestMethod]
        public void RightCommandSuccessful()
        {
            //Arrange
            GameManager.Pac = new Pacman.Pacman(2, 2, "NORTH");
            RightCommand ric = new RightCommand();
            ReportCommand rec = new ReportCommand();
            String input = "RIGHT";
            ric.execute(input);

            //Assert
            Assert.AreEqual(rec.execute("RIGHT"), "Output: 2,2,EAST");
        }

        [TestMethod]
        public void RightCommandWrongParams()
        {
            //Arrange
            GameManager.Pac = new Pacman.Pacman(2, 2, "NORTH");
            RightCommand rc = new RightCommand();
            String input = "RIGHT JOIN";

            //Assert
            Assert.AreEqual(rc.execute(input), "'RIGHT' command does not need any parameters");
        }

        [TestMethod]
        public void RightCommandUnsuccessful()
        {
            //Arrange
            GameManager.Pac = null;
            RightCommand rc = new RightCommand();
            String input = "";

            //Assert
            Assert.AreEqual(rc.execute(input), "Make sure the Pacman is placed on the grid before you can rotate or move it");
        }
    }
    
}
