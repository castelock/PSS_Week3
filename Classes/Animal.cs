
namespace Classes
{
    internal class Animal
    {
        // Attributes
        string name;
        string color;

        // Default constructor
        public Animal()
        {
            name = "tiger";
            color = "orange";
        }

        public void move()
        {
            Console.WriteLine("Animal moving");
        }

        public void sleep()
        {
            Console.WriteLine("Animal sleeping");
        }

    }
}
