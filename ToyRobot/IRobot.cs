namespace ToyRobot
{
    public interface IRobot
    {
        void Place(int x, int y, Face face);
        void Move();
        void Right();
        void Left();
        string Report();
    }
}
