using NUnit.Framework;

namespace ToyRobot.Tests
{

    public class LeftTests
    {
        private Robot _robot = new Robot();

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(Face.NORTH, Face.WEST)]
        [TestCase(Face.WEST, Face.SOUTH)]
        [TestCase(Face.SOUTH, Face.EAST)]
        [TestCase(Face.EAST, Face.NORTH)]
        public void Left_RobotOnTable_RotatesLeft(Face startingFace, Face expectedFace)
        {
            _robot.Place(1, 1, startingFace);
            string response = _robot.Report();
            Assert.That(response, Is.EqualTo($"1,1,{startingFace}"));

            _robot.Left();
            response = _robot.Report();
            Assert.That(response, Is.EqualTo($"1,1,{expectedFace}"));
        }
    }
}