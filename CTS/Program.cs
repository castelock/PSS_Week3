// See https://aka.ms/new-console-template for more information

namespace CTS
{
    public class Program
    {

        public static void Main(string[] args)
        {

            int i = 10;

            // Type Integer

            Type tInteger = i.GetType();

            Console.WriteLine("Integer information: ");

            Console.WriteLine(tInteger.BaseType);

            Console.WriteLine(tInteger.Name);

            Console.WriteLine(tInteger.FullName);

            Console.WriteLine(tInteger.Namespace);

            Console.WriteLine();

            // Type String

            string text = "computer";

            Type tString = text.GetType();

            Console.WriteLine("String information: ");

            Console.WriteLine(tString.BaseType);

            Console.WriteLine(tString.Name);

            Console.WriteLine(tString.FullName);

            Console.WriteLine(tString.Namespace);



        }
    }
}

