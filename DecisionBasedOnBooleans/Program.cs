using System;

namespace DecisionBasedOnBooleans
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Is the lecture topic interesting? (y/n): ");
            bool interesting = Console.ReadLine().ToLower() == "y";

            Console.Write("Does one of your friends join? (y/n): ");
            bool friendJoins = Console.ReadLine().ToLower() == "y";

            Console.Write("Do you have problems with the assignment? (y/n): ");
            bool problems = Console.ReadLine().ToLower() == "y";

            
            if (interesting && (friendJoins || problems))
            {
                Console.WriteLine("Go. ✅");
            }
            else
            {
                Console.WriteLine("Stay. ❌");
            }
        }
    }
}