using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (num < 100)
            {
                num++;
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }         
                else
                {
                    Console.WriteLine(num);
                    continue;
                }
            }
        }
    }
}
