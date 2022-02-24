namespace ReferenceEquals
{
    public class Program
    {

        public static void Main(string[] args)
        {

            object o = null;
            object p = null;
            object q = new Object();

            Console.WriteLine(Object.ReferenceEquals(o, p));
            p = q;
            Console.WriteLine(Object.ReferenceEquals(p, q));
            Console.WriteLine(Object.ReferenceEquals(o, p));



        }

    }
}