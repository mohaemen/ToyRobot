using NUnit.Framework;

namespace ToyRobot.Tests
{

    public class RightTests
    {
        private Robot _robot = new Robot();

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(Face.NORTH, Face.EAST)]
        [TestCase(Face.EAST, Face.SOUTH)]
        [TestCase(Face.SOUTH, Face.WEST)]
        [TestCase(Face.WEST, Face.NORTH)]
        public void Right_RobotOnTable_RotatesRight(Face startingFace, Face expectedFace)
        {
            _robot.Place(1, 1, startingFace);
            string response = _robot.Report();
            Assert.That(response, Is.EqualTo($"1,1,{startingFace}"));

            _robot.Right();
            response = _robot.Report();
            Assert.That(response, Is.EqualTo($"1,1,{expectedFace}"));
        }

    }
}