
namespace BoxingUnboxing
{
   
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("**********BOXING**********");
            // assigned int value
            // 2020 to num
            int num = 2020;

            // Boxing
            object obj = num;

            // value of num to be change
            num = 100;

            System.Console.WriteLine
            ("Value - type value of num is : {0}", num);
            System.Console.WriteLine
            ("Object - type value of obj is : {0}", obj);

            Console.WriteLine("**********UNBOXING**********");

            // assigned int value
            // 23 to num
            int num2 = 23;

            // Boxing
            object obj2 = num2;

            // Unboxing
            int i = (int)obj2;

            // Display result
            Console.WriteLine("Value of ob object is : " + obj2);
            Console.WriteLine("Value of i is : " + i);
        }

    }
}
