namespace ToyRobot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            List<string> commands = new List<string>();

            Console.WriteLine("Enter your commands one per line pressing Enter after each command.");
            Console.WriteLine("Once completed, type 'EXIT' in the new line and press enter.");
            string command = Console.ReadLine();

            while (command != "EXIT")
            {
                commands.Add(command);
                command = Console.ReadLine();
            }

            if (commands.Any())
            {
                Robot robot = new Robot();
                IOutput output = new Output();
                RobotManager _robotManager = new RobotManager(robot, output);
                _robotManager.RunCommands(commands.ToArray());
            }
        }
    }
}
