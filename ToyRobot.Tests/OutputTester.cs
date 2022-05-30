using System;

namespace ToyRobot.Tests
{
    public class OutputTester : IOutput
    {
        public string Result { get; set; }
        public void OutputIt(string result)
        {
            Result = result;
        }
    }
}