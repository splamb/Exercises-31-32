using System;

namespace Exercise32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[] { 2, 8, 0, 24, 51 };
            string cont = "y";


            while (cont == "y")
            {
                Console.WriteLine("Please enter a number: ");
                int number = int.Parse(Console.ReadLine());
                int length = 5;
                int numberIndex;
                bool check = false;

                for(int i = 0; i < length ; i++)
                {
                    if (number == numberArray[i])
                    {
                        numberIndex = Array.IndexOf(numberArray, number);
                        Console.WriteLine($"The value {number} can be found at index {numberIndex}.");
                        check = true;
                        break;
                    }                  
                }
                if (check == false)
                {
                    Console.WriteLine($"The value {number} is not in the array.");
                }


                Console.WriteLine("Would you like to continue? (y/n)");
                cont = Console.ReadLine();
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
