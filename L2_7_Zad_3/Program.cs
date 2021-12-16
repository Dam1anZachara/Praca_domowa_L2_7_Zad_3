using System;

namespace L2_7_Zad_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program will check if the number is positive or negative ");
            Console.WriteLine("Please enter an intiger number.");

            Int32.TryParse(Console.ReadLine(), out int numberInt);

            if (numberInt > 0)
            {
                Console.WriteLine($"Entered number {numberInt} is positive.");
            }
            else if (numberInt < 0)
            {
                Console.WriteLine($"Entered number {numberInt} is negative.");
            }
            else
            {
                Console.WriteLine($"Entered number {numberInt} equal to 0.");
            }
        }
    }
}
