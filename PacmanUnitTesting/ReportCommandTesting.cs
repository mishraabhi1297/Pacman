using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacman;

namespace PacmanUnitTesting
{
    [TestClass]
    public class ReportCommandTesting
    {
        [TestMethod]
        public void ReportCommandSuccessful()
        {
            //Arrange
            GameManager.Pac = new Pacman.Pacman(2, 2, "NORTH");
            ReportCommand rc = new ReportCommand();
            String input = "REPORT";

            //Assert
            Assert.AreEqual(rc.execute(input), "Output: 2,2,NORTH");
        }

        [TestMethod]
        public void ReportCommandWrongParams()
        {
            //Arrange
            GameManager.Pac = new Pacman.Pacman(2, 2, "NORTH");
            ReportCommand rc = new ReportCommand();
            String input = "REPORT BUDDY";

            //Assert
            Assert.AreEqual(rc.execute(input), "'REPORT' command does not need any parameters");
        }

        [TestMethod]
        public void ReportCommandUnsuccessful()
        {
            //Arrange
            GameManager.Pac = null;
            ReportCommand rc = new ReportCommand();
            String input = "REPORT";

            //Assert
            Assert.AreEqual(rc.execute(input), "Make sure the Pacman is placed on the grid before you can rotate or move it");
        }
    }
}
