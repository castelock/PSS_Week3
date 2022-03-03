
namespace Enums
{
    public class Program
    {
        public enum Fruits
        {
            Apple,
            Banana,
            Orange,
            Watermelon,
            Mango,
            Strawberry
        }

        [Flags]
        public enum Days
        {
            None = 0b_0000_0000,  // 0
            Monday = 0b_0000_0001,  // 1
            Tuesday = 0b_0000_0010,  // 2
            Wednesday = 0b_0000_0100,  // 4
            Thursday = 0b_0000_1000,  // 8
            Friday = 0b_0001_0000,  // 16
            Saturday = 0b_0010_0000,  // 32
            Sunday = 0b_0100_0000,  // 64
            Weekend = Saturday | Sunday
        }
        public static void Main(string[] args)
        {

            Console.WriteLine("The options for this program are: {0} 1- Example of enum. {0} " +
                 "2- Example of enum with flags. {0} ", Environment.NewLine);
            Console.WriteLine("Insert one of the previous options: ");
            int option = 0;
            string answer = Console.ReadLine();
            option = Convert.ToInt32(answer);

            switch (option)
            {
                case 1:
                    foreach (var fruit in Enum.GetNames(typeof(Fruits)))
                    {
                        Console.WriteLine(fruit);
                    }

                    
                    break;
                case 2:
                    Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
                    Console.WriteLine(meetingDays);

                    Days workingFromHomeDays = Days.Thursday | Days.Friday;
                    Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");

                    bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
                    Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");
                 
                    break;
                default:
                    Console.WriteLine("Option not valid. Please insert a new option.");
                    break;
            }    

            

        }

    }
}
