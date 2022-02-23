
namespace Interfaces
{
    delegate int Calculate(int a, int b);
    public class Program
    {
        public int add(int x, int y)
        {
            return x + y;
        }

        public int subtract(int x, int y)
        {
            return x - y;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Adding and subtracting two values through delegates");
            Program p = new Program();
            int a = 8;
            int b = 3;
            Calculate del = p.add;
            Console.WriteLine("Result of adding: " + del(a, b));
            del = p.subtract;
            Console.WriteLine("Result of subtracting: " + del(a, b));
        }

    }
}
