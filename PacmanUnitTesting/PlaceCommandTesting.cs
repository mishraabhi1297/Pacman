using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pacman;

namespace PacmanUnitTesting
{
    [TestClass]
    public class PlaceCommandTesting
    {
        [TestMethod]
        public void PlaceCommandSuccessful()
        {
            //Arrange
            PlaceCommand pc = new PlaceCommand(new Vector2D(5, 5));
            String input = "PLACE 2,2,NORTH";

            //Assert
            Assert.AreEqual(pc.execute(input), "");
        }

        [TestMethod]
        public void PlaceCommandWrongDirection()
        {
            //Arrange
            PlaceCommand pc = new PlaceCommand(new Vector2D(5, 5));
            String input = "PLACE 2,2,JUNGLE";

            //Assert
            Assert.AreEqual(pc.execute(input), "Error. Direction can only be NORTH, SOUTH, EAST, WEST");
        }

        [TestMethod]
        public void PlaceCommandWrongParameters()
        {
            //Arrange
            PlaceCommand pc = new PlaceCommand(new Vector2D(5, 5));
            String input = "PLACE 2,2,NORTH,SOUTH";

            //Assert
            Assert.AreEqual(pc.execute(input), "Error. Please enter 3 elements as follows, Position X, Position Y and Direction");
        }

        [TestMethod]
        public void PlaceCommandWrongGridSize()
        {
            //Arrange
            PlaceCommand pc = new PlaceCommand(new Vector2D(5, 5));
            String input = "PLACE 7,2,NORTH";

            //Assert
            Assert.AreEqual(pc.execute(input), "Error. Please enter a size of 5 units x 5 units");
        }

        [TestMethod]
        public void PlaceCommandInsufficientInfo()
        {
            //Arrange
            PlaceCommand pc = new PlaceCommand(new Vector2D(5, 5));
            String input = "PLACE";

            //Assert
            Assert.AreEqual(pc.execute(input), "Error. Please enter the details of Place Command (i.e., PLACE 1,1,NORTH)");
        }
    }
}
