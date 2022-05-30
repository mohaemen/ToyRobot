using NUnit.Framework;

namespace ToyRobot.Tests
{

    public class MoveTests
    {
        private Robot _toyRobot = new Robot();

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0,0, Face.EAST, "1,0,EAST")]
        [TestCase(1,0, Face.EAST, "2,0,EAST")]
        [TestCase(2,0, Face.EAST, "3,0,EAST")]
        [TestCase(3,0, Face.EAST, "4,0,EAST")]
        public void Move_ValidMove_Moves(int x, int y, Face face, string expectedPosition)
        {
             _toyRobot.Place(x,y, face);
            _toyRobot.Move();

            string response = _toyRobot.Report();

            Assert.That(response, Is.EqualTo(expectedPosition));
        }

        [TestCase(2,0, Face.SOUTH)]
        [TestCase(4,3, Face.EAST)]
        [TestCase(2,4, Face.NORTH)]
        [TestCase(0,1, Face.WEST)]
        public void Move_InvalidMove_Ignored(int x, int y, Face face)
        {
             _toyRobot.Place(x,y, face);
            _toyRobot.Move();

            string response = _toyRobot.Report();

            Assert.That(response, Is.EqualTo($"{x},{y},{face}"));
        }

    }
}