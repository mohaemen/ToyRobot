namespace ToyRobot.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    public class ExampleTests
    {
        private OutputTester _output = new OutputTester();
        private RobotManager _robotManager;

        [SetUp]
        public void SetUp() => _robotManager = new RobotManager(new Robot(), _output);

        [Test]
        public void Example1()
        {
            string expectedResult = "0,1,NORTH" + Environment.NewLine;

            List<string> commands = new List<string>();
            commands.Add("PLACE 0,0,NORTH");
            commands.Add("MOVE");
            commands.Add("REPORT");

            _robotManager.RunCommands(commands.ToArray());

            Assert.That(_output.Result, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Example2()
        {
            string expectedResult = "0,0,WEST" + Environment.NewLine;

            List<string> commands = new List<string>();
            commands.Add("PLACE 0,0,NORTH");
            commands.Add("LEFT");
            commands.Add("REPORT");

            _robotManager.RunCommands(commands.ToArray());

            Assert.That(_output.Result, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void Example3()
        {
            string expectedResult = "3,3,NORTH" + Environment.NewLine;

            List<string> commands = new List<string>();
            commands.Add("PLACE 1,2,EAST");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("LEFT");
            commands.Add("MOVE");
            commands.Add("REPORT");

            _robotManager.RunCommands(commands.ToArray());

            Assert.That(_output.Result, Is.EqualTo(expectedResult));
        }
    }
}
