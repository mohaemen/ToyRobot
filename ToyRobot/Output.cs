using System;

namespace ToyRobot
{
    public class Output : IOutput
    {
        public void OutputIt(string result)
        {
            Console.Write(result);
        }
    }
}