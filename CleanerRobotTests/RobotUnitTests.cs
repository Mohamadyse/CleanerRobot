using CleanerRobot;
using NUnit.Framework;
using NUnit;
using System.Collections.Generic;

namespace CleanerRobotTests
{
    public class RobotUnitTests
    {
        private Robot _sut; 

        [SetUp]
        public void Setup()
        {
            _sut = new Robot();
        }

        [Test]
        public void Verify_GetAllNewPlacesPerCommand_ReturnsListOfNewVisitedVertices()
        {
            // Arrange
            (int X, int Y) startCoordinate= (0,0);
            (string Direction, int NumberOfSteps) command = ("E", 1);

            // Act
            var result = _sut.GetAllNewVerticesPerCommand(startCoordinate, command);    

            // Assert
            Assert.AreEqual(new[] { (1, 0) },result);
        }

        [Test]
        public void Verify_NumberUniquePlacesForAllCommands_ReturnsTwoForOneVirtexMovement()
        {
            // Arrange
            (int X, int Y) startCoordinate = (0, 0);
            var commands = new List<(string,int)>{ ("E", 1) };

            // Act
            var result = _sut.NumberOfUniqueVerticesForAllCommands(startCoordinate,commands,1);

            // Assert
            Assert.AreEqual(2 , result);
        }
    }
}