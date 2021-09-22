using System;

namespace weekoneloops2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string FizzBuzz = "";
                if (i % 3 == 0)
                {
                    FizzBuzz = FizzBuzz + "Fizz";
                }
                if (i % 5 == 0)
                {
                    FizzBuzz = FizzBuzz + "Buzz";
                }
                if (i % 5 != 0 && i % 3 != 0)
                {
                    FizzBuzz = Convert.ToString(i);
                }
                Console.WriteLine(FizzBuzz);
            }
            /*for (int i = 1; i <= 100; i++)
            {
                if(i%5 ==0 && i%3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }*/

        }
    }
}
