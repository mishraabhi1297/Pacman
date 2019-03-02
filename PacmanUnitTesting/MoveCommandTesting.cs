using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacman;

namespace PacmanUnitTesting
{
    [TestClass]
    public class MoveCommandTesting
    {
        [TestMethod]
        public void MoveCommandSuccessful()
        {
            //Arrange
            GameManager.Pac = new Pacman.Pacman(2, 2, "NORTH");
            MoveCommand mc = new MoveCommand();
            ReportCommand rc = new ReportCommand();
            String input = "MOVE";
            mc.execute(input);

            //Assert
            Assert.AreEqual(rc.execute("REPORT"), "Output: 2,3,NORTH");
        }

        [TestMethod]
        public void MoveCommandWrongParams()
        {
            //Arrange
            GameManager.Pac = new Pacman.Pacman(2, 2, "NORTH");
            MoveCommand mc = new MoveCommand();
            String input = "MOVE MATE";

            //Assert
            Assert.AreEqual(mc.execute(input), "'MOVE' command does not need any parameters");
        }

        [TestMethod]
        public void MoveCommandOffGrid()
        {
            //Arrange
            GameManager.Pac = new Pacman.Pacman(2, 5, "NORTH");
            MoveCommand mc = new MoveCommand();
            String input = "MOVE";

            //Assert
            Assert.AreEqual(mc.execute(input), "Cannot move off the grid");
        }

        [TestMethod]
        public void MoveCommandUnsuccessful()
        {
            //Arrange
            GameManager.Pac = null;
            MoveCommand mc = new MoveCommand();
            String input = "";

            //Assert
            Assert.AreEqual(mc.execute(input), "Make sure the Pacman is placed on the grid before you can rotate or move it");
        }
    }
}
