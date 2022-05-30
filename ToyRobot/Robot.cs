namespace ToyRobot
{
    public class Robot : IRobot
    {
        private const int Max_X = 4;
        private const int Max_Y = 4;

        private int? _x;
        private int? _y;
        private Face _face;

        public void Place(int x, int y, Face face)
        {
            if (x < 0 || y < 0 || x > Max_X || y > Max_Y)
            {
                return;
            }

            _x = x;
            _y = y;
            _face = face;
        }

        public void Move()
        {
            if (IsRobotNotOnTable())
            {
                return;
            }

            switch (_face)
            {
                case Face.EAST:
                    if (_x < Max_X)
                    {
                        _x++;
                    }
                    break;
                case Face.SOUTH:
                    if (_y >0 )
                    {
                        _y--;
                    }
                    break;
                case Face.WEST:
                    if (_x > 0)
                    {
                        _x--;
                    }
                    break;
                case Face.NORTH:
                    if (_y < Max_Y)
                    {
                        _y++;
                    }
                    break;
            }
        }

        public void Right()
        {
            if (IsRobotNotOnTable())
            {
                return;
            }

            if (_face == Face.WEST)
            {
                _face = Face.NORTH;
            }
            else
            {
                _face++;
            }
        }

        public void Left()
        {
            if (IsRobotNotOnTable())
            {
                return;
            }

            if (_face == Face.NORTH)
            {
                _face = Face.WEST;
            }
            else
            {
                _face--;
            }
        }

        public string Report()
        {
            if (IsRobotNotOnTable())
            {
                return Messages.RobotNotPlaced;
            }

            return $"{_x},{_y},{_face}";
        }

        private bool IsRobotNotOnTable() => _x == null && _y == null;
    }
}
