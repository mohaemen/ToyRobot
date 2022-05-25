namespace ToyRobot
{
    public class Robot
    {
        private int _x;
        private int _y;
        private Face _face;

        public string Place(int x, int y, Face face)
        {
            _x = x;
            _y = y;
            _face = face;
            return "Success";
        }

        public string Move()
        {
            return "";
        }

        public string Right()
        {
            return "";

        }

        public string Left()
        {
            return "";

        }

        public string Report()
        {
            return $"{_x} {_y} {_face}";
        }
    }
}
