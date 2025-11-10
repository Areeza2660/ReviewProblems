using System;

namespace DigitSumModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            
            while (number > 0)
            {
                
                int digit = number % 10;

                
                sum += digit;

                
                number = number / 10;
            }

            
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
