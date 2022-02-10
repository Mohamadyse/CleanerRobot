using CleanerRobot;
using NUnit.Framework;
using NUnit;
using System.Collections.Generic;

namespace CleanerRobotTests
{
    public class Tests
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
            (string Direction, int NumberOfSteps) comand = ("E", 1);

            // Act
            var result = _sut.GetAllNewPlacesPerCommand(startCoordinate, comand);    

            // Assert
            Assert.AreEqual(new[] { (1, 0) },result);
        }
    }
}