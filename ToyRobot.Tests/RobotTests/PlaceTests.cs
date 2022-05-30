using NUnit.Framework;

namespace ToyRobot.Tests
{

    public class PlaceTests
    {
        private Robot _robot = new Robot();

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 0, Face.EAST, "0,0,EAST")]
        [TestCase(4, 0, Face.NORTH, "4,0,NORTH")]
        [TestCase(0, 4, Face.WEST, "0,4,WEST")]
        [TestCase(4, 4, Face.SOUTH, "4,4,SOUTH")]
        public void Place_ValidPosition_Places(int x, int y, Face face, string expectedResponse)
        {
            _robot.Place(x, y, face);
            string response = _robot.Report();

            Assert.That(response, Is.EqualTo(expectedResponse));
        }

        [TestCase(-1, 0, Face.EAST)]
        [TestCase(5, 0, Face.NORTH)]
        [TestCase(0, -1, Face.WEST)]
        [TestCase(4, 5, Face.SOUTH)]
        public void Place_InvalidPosition_DoesNotPlace(int x, int y, Face face)
        {
             _robot.Place(x, y, face);
            string response = _robot.Report();
            Assert.That(response, Is.EqualTo(Messages.RobotNotPlaced));
        }
    }
}