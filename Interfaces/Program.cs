
namespace Interfaces
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The options for this program are: {0} 1- Example of interface. {0} " +
                 "2- Example of multiple interfaces. {0} ", Environment.NewLine);
            Console.WriteLine("Insert one of the previous options: ");
            int option = 0;
            string answer = Console.ReadLine();
            option = Convert.ToInt32(answer);

            switch (option)
            {
                case 1:
                    Rectangle r1 = new Rectangle();
                    r1.calculateArea();

                    Square s1 = new Square();
                    s1.calculateArea();
                    break;
                case 2:
                    RectangleMult rectangleMult = new RectangleMult();
                    rectangleMult.calculateArea();
                    rectangleMult.getColor();
                    break;
                default:
                    Console.WriteLine("Option not valid. Please insert a new option.");
                    break;
            }

        }

    }
}
