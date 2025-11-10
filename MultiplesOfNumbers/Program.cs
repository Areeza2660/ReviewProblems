using System;

namespace MultiplesOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("Enter dividend: ");
            double dividend = double.Parse(Console.ReadLine());

            Console.Write("Enter divisor: ");
            double divisor = double.Parse(Console.ReadLine());

            
            if (divisor == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return;
            }

            
            double remainder = dividend % divisor;

            // 
            if (Math.Abs(remainder) < 0.000001)
            {
                Console.WriteLine("Multiples");
            }
            else
            {
                Console.WriteLine("Not multiples");
            }
        }
    }
}
