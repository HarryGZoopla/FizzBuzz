using System;
namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var counter = 0; counter < 110; counter++)
            {
                if (counter % 11 == 0)
                {
                    Console.WriteLine("Bong");
                }
                else if (counter % 3 == 0 && counter % 5 == 0 && counter % 7 == 0)
                {
                    Console.WriteLine("FizzBuzzBang");
                }
                else if (counter % 3 == 0 && counter % 7 == 0)
                {
                    Console.WriteLine("FizzBang");
                }
                else if (counter % 7 == 0 && counter % 5 == 0)
                {
                    Console.WriteLine("BuzzBang");
                }
                else if (counter % 3 == 0 && counter % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (counter % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (counter % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (counter % 7 == 0)
                {
                    Console.WriteLine("Bang");
                }
                else Console.WriteLine(counter);
            }
        }
    }
}