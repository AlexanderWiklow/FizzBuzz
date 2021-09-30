using System;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //You have a collection of integers, 1 to 100.  I want you to cycle through this collection.  For each number found that is evenly divisible by 3, output the word "Fizz".  For each number that is evenly divisible by 5, output the word "Buzz".   For each number that is evenly divisible by both 3 AND 5, output the word "FizzBuzz

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            
            }
        }
    }
}
