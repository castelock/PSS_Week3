namespace Equals
{
    public class Program
    {
       
        public static void Main(string[] args)
        {

            Point point2D = new Point(5, 5);
            Point3D point3Da = new Point3D(5, 5, 2);
            Point3D point3Db = new Point3D(5, 5, 2);
            Point3D point3Dc = new Point3D(5, 5, -1);

            Console.WriteLine("{0} = {1}: {2}",
                              point2D, point3Da, point2D.Equals(point3Da));
            Console.WriteLine("{0} = {1}: {2}",
                              point2D, point3Db, point2D.Equals(point3Db));
            Console.WriteLine("{0} = {1}: {2}",
                              point3Da, point3Db, point3Da.Equals(point3Db));
            Console.WriteLine("{0} = {1}: {2}",
                              point3Da, point3Dc, point3Da.Equals(point3Dc));

            

        }

    }
}