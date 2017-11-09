using System;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // for (int i = 1; i <= 255; i++)
            // {
            //     Console.WriteLine(i);
            // }

            // for(int i = 1; i <= 100; i++)
            // {
            //     if(i % 3 == 0) {
            //         System.Console.WriteLine("Fizz");
            //     }
            //     if (i % 5 == 0)
            //     {
            //         System.Console.WriteLine("Buzz");
            //     }
            // }

            Random rand = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int newRand = rand.Next(1, 100);
                if(newRand % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                }
                if (newRand % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                }
            }
        }
    }
}


