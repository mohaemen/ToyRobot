using NUnit.Framework;

namespace ToyRobot.Tests
{

    public class RightTests
    {
        private Robot _toyRobot = new Robot();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Place_Places()
        {
            string response = _toyRobot.Place(0, 0, Face.East);

            Assert.That(response, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Move_Moves()
        {
            string response = _toyRobot.Move();
            Assert.That(response, Is.EqualTo(string.Empty));

        }

        [Test]
        public void Right_RotatesRight()
        {
            string response = _toyRobot.Report();
            Assert.That(response, Is.EqualTo(string.Empty));

        }

        [Test]
        public void Left_RotatesLeft()
        {
            string response = _toyRobot.Left();
            Assert.That(response, Is.EqualTo(string.Empty));

        }
    }
}