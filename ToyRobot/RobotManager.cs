using System;

namespace ToyRobot
{
    public class RobotManager
    {
        private IRobot _robot;
        private readonly IOutput _output;

        public RobotManager(IRobot robot, IOutput output)
        {
            _robot = robot;
            _output = output;
        }

        public void RunCommands(params string[] commands)
        {
            foreach (string command in commands)
            {
                string[] commandParts = command.Split(' ');
                switch (commandParts.Length)
                {
                    case 1:
                        MoveOrTurn(command);
                        break;
                    case 2:
                        Place(commandParts);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Place(string[] commandParts)
        {
            if (commandParts[0] != "PLACE")
            {
                return;
            }

            string[] position = commandParts[1].Split(',');

            if (position.Length != 3)
            {
                return;
            }

            if (!int.TryParse(position[0], out int x))
            {
                return;
            }

            if (!int.TryParse(position[1], out int y))
            {
                return;
            }

            if (!TryParse(position[2], out Face face))
            {
                return;
            }

            _robot.Place(x, y, face);
        }

        private void MoveOrTurn(string command)
        {
            switch (command)
            {
                case "RIGHT":
                    _robot.Right();
                    break;
                case "LEFT":
                    _robot.Left();
                    break;
                case "MOVE":
                    _robot.Move();
                    break;
                case "REPORT":
                    _output.OutputIt(_robot.Report() + Environment.NewLine);
                    break;
            }
        }

        private bool TryParse(string direction, out Face face)
        {
            face = Face.NORTH;

            switch (direction)
            {
                case "NORTH":
                    face = Face.NORTH;
                    return true;
                case "EAST":
                    face = Face.EAST;
                    return true;
                case "SOUTH":
                    face = Face.SOUTH;
                    return true;
                case "WEST":
                    face = Face.WEST;
                    return true;
                default:
                    return false;
            }
        }
    }
}
