using NUnit.Framework;

namespace ToyRobot.Tests
{

    public class PlaceTests
    {
        private Robot _toyRobot = new Robot();

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 0, Face.East, "0 0 East")]
        [TestCase(4, 0, Face.North, "4 0 North")]
        [TestCase(0, 4, Face.West, "0 4 West")]
        [TestCase(4, 4, Face.South, "4 4 South")]
        public void Place_Places(int x, int y, Face face, string expectedResponse)
        {
            _toyRobot.Place(x, y, face);
            string response = _toyRobot.Report();

            Assert.That(response, Is.EqualTo(expectedResponse));
        }
    }
}