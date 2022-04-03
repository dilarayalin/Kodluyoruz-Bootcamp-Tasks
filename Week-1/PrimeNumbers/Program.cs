using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * Program to list prime numbers from 1 to 10000
             */


            bool isPrime = true;

            for (int i = 2; i < 10000; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine(i);
                    }
                    isPrime = true;
                }
            }


        }
    }
}
