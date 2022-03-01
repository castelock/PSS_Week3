namespace Struct
{
    public class Program
    {
        public struct Point
        {
            public int x;
            public int y;

            public override string ToString()
            {
                return "The value of x is: " + x.ToString() + " and the value of y is: " + y.ToString();
            }
        }

        public struct Point2
        {
            public int x { get; set; }
            public int y { get; set; }

            public Point2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return "The value of x is: " + x.ToString() + " and the value of y is: " + y.ToString();
            }
        }


        public static void Main(string[] args)
        {
            Point point = new Point();
            Console.WriteLine(point.ToString());

            Point2 point2 = new Point2(2, 3);
            Console.WriteLine(point2.ToString());

            point2.x = 5;
            point2.y = 10;
            Console.WriteLine(point2.ToString());

            Point2 point3 = new Point2(1, 0);
            point3 = point2;
            Console.WriteLine(point3.ToString());
        }

    }
}
