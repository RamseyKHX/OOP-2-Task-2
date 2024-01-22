namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 2 //
            int lowNumber = 0;
            int highNumber = 0;


            while (lowNumber <= 0)
            {
                Console.Write("Enter a positive low number: ");
                if (!int.TryParse(Console.ReadLine(), out lowNumber) || lowNumber <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    lowNumber = 0; 
                }
            }

            
            while (highNumber <= lowNumber)
            {
                Console.Write($"Enter a high number greater than {lowNumber}: ");
                if (!int.TryParse(Console.ReadLine(), out highNumber) || highNumber <= lowNumber)
                {
                    Console.WriteLine($"Invalid input. Please enter an integer greater than {lowNumber}.");
                    highNumber = 0; 
                }
            }

            Console.WriteLine($"The low number is: {lowNumber}");
            Console.WriteLine($"The high number is: {highNumber}");
        }
    }
}

