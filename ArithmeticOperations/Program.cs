using System;

namespace ArithmeticOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first integer: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int second = int.Parse(Console.ReadLine());

            
            int sum = first + second;
            int product = first * second;
            int difference = first - second;
            int quotient = 0;
            int remainder = 0;

           
            if (second != 0)
            {
                quotient = first / second;
                remainder = first % second;
            }

          
            Console.WriteLine("Result:");
            Console.WriteLine(sum);
            Console.WriteLine(product);
            Console.WriteLine(difference);
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);
        }
    }
}