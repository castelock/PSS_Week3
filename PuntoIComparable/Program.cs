namespace PuntoIComparable
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Punto p1 = new(2, 3);
            Punto p2 = new(2, 3);
            Punto p3 = new(3, 2);
            Punto p4 = new(1, 1);

            Console.WriteLine("p1 = " + p1);
            Console.WriteLine("p2 = " + p2);
            Console.WriteLine("p3 = " + p3);
            Console.WriteLine("p4 = " + p4);

            Console.WriteLine(p1.Equals(null));     // False
            Console.WriteLine(p1.Equals(p2));       // True
            Console.WriteLine(p1 == p2);            // True
            Console.WriteLine(p1.CompareTo(p2));    // 0
            Console.WriteLine(p1.CompareTo(p3));    // 0
            Console.WriteLine(p1.Equals(p3));       // False
            Console.WriteLine(p1 == p3);            // False
            Console.WriteLine(p1.CompareTo(p4));    // 1
            Console.WriteLine(p4.CompareTo(p1));    // -1
            Console.WriteLine(p1.CompareTo(null));  // 1

            List<Punto> Puntos = new List<Punto>();
            Puntos.Add(p1);
            Puntos.Add(p2);
            Puntos.Add(p3);
            Puntos.Add(p4);

            Console.WriteLine("\nLista\n=====");
            foreach (Punto p in Puntos) Console.WriteLine(p);

            Puntos.Sort();
            Console.WriteLine("\nLista\n=====");
            foreach (Punto p in Puntos) Console.WriteLine(p);


        }

    }
}