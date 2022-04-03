using System;

namespace IsPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Program to check if the entered number is prime
             */

            Console.WriteLine("Please enter a number: ");
            bool isPrime = true, typeControl = true;
            string text;
            

            while(typeControl)
            {
                text = Console.ReadLine();
                if (Int32.TryParse(text, out int number))
                {
                    
                    for (int i = 2; i < number; i++)
                    {
                        if (number % i == 0)
                        {
                            Console.WriteLine($"{number} is not a prime number.");
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine($"{number} is a prime number.");
                    }
                    typeControl = false;
                }
                else
                {
                    Console.WriteLine($"Please input a valid number. The data entered: {text}");
                }
                

            }

            
            
                
                
                
            
            
            

        }
    }
}
