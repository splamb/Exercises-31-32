using System;

namespace Exercises31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[] { 2, 8, 0, 24, 51 };
            int arrayIndex;
            string cont = "y";


            while(cont == "y")
            {
                Console.WriteLine("Please enter an index of the array: ");
                arrayIndex = int.Parse(Console.ReadLine());

                Console.WriteLine($"The value at index {arrayIndex} is {numberArray.GetValue(arrayIndex)}");

                Console.WriteLine("Would you like to continue? (y/n)");
                cont = Console.ReadLine();
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
