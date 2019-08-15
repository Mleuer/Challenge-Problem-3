namespace Challenge_Problem_3.Util
{
    public class Coordinate2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinate2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coordinate2D()
        {
            X = 0;
            Y = 0;
        }
    }
}