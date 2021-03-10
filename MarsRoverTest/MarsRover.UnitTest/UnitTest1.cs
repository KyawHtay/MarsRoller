using Microsoft.VisualStudio.TestTools.UnitTesting;

using MarsRoverTest.Models;
using System.Collections.Generic;
using System;

namespace MarsRover.UnitTest
{
    [TestClass]
    public class MarRoverTest
    {

        [TestMethod]
        public void InstructionScanrio_12NLMLMLMLMM_13N()
        {
            //Arrange
            Position position = new Position()
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "LMLMLMLMM";

            //Act
            position.StartMoving(maxPoints, moves);

            var actualOutput = String.Format("{0} {1} {2}", position.X, position.Y, position.Direction.ToString());
            var expectedOutput = "1 3 N";

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void InstructionScanrio_33EMRRMMRMRRM_23S()
        {
            Position position = new Position()
            {
                X = 3,
                Y = 3,
                Direction = Directions.E
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "MRRMMRMRRM";

            position.StartMoving(maxPoints, moves);

            var actualOutput = String.Format("{0} {1} {2}", position.X, position.Y, position.Direction.ToString());
            var expectedOutput = "2 3 S";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
