using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace ToyRobot.Tests
{

    public class RobotManagerTests
    {
        private OutputTester _output = new OutputTester();
        private RobotManager _robotManager;

        [SetUp]
        public void SetUp() => _robotManager = new RobotManager(new Robot(), _output);

        [Test]
        public void GivenListOfCommands1_Exucte_ExpectedResult()
        {
            string expectedResult = "0,0,SOUTH" + Environment.NewLine;

            List<string> commands = new List<string>();
            commands.Add("PLACE 0,0,NORTH");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("RIGHT");
            commands.Add("RIGHT");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("REPORT");

            _robotManager.RunCommands(commands.ToArray());

            Assert.That(_output.Result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenListOfCommands2_Exucte_ExpectedResult()
        {
            string expectedResult = "4,4,EAST" + Environment.NewLine;

            List<string> commands = new List<string>();
            commands.Add("PLACE 0,0,NORTH");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("RIGHT");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("REPORT");

            _robotManager.RunCommands(commands.ToArray());

            Assert.That(_output.Result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Given2PlaceCommands_Exucte_ExpectedResult()
        {
            string expectedResult = "3,4,NORTH" + Environment.NewLine;

            List<string> commands = new List<string>();
            commands.Add("PLACE 4,4,SOUTH");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("RIGHT");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("MOVE");
            commands.Add("PLACE 3,3,NORTH");
            commands.Add("MOVE");
            commands.Add("REPORT");

            _robotManager.RunCommands(commands.ToArray());

            Assert.That(_output.Result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenListOfInvalidCommands_Ignored_RobotNotPlaced()
        {
            List<string> commands = new List<string>();
            commands.Add("PLACE 0,0,1,NORTH");
            commands.Add("MOVE1");
            commands.Add("right");
            commands.Add("left");
            commands.Add("report");
            commands.Add("MOVE ");
            commands.Add("ivalid");
            commands.Add("back");
            commands.Add("Back");
            commands.Add("REPORT");

            _robotManager.RunCommands(commands.ToArray());

            Assert.That(_output.Result, Is.EqualTo(Messages.RobotNotPlaced + Environment.NewLine));
        }

    }
}