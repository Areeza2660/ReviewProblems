using System;

namespace AdultCorpulenceIndex
{
    class Program
    {
        
        const double underWeightMax = 11;
        const double normalWeightMax = 14;
        const double overWeightMax = 18;
        const double obeseMax = 24;

       
        static double ci(double mass, double height)
        {
            return mass / Math.Pow(height, 3);
        }

        static void Main(string[] args)
        {
            
            Console.Write("Enter mass in kg: ");
            double mass = double.Parse(Console.ReadLine());

            Console.Write("Enter height in m: ");
            double height = double.Parse(Console.ReadLine());

            
            double corpulenceIndex = Math.Round(ci(mass, height), 2);

            string category;

            
            if (corpulenceIndex < underWeightMax)
            {
                category = "severely underweight";
            }
            else if (corpulenceIndex < normalWeightMax)
            {
                category = "underweight";
            }
            else if (corpulenceIndex < overWeightMax)
            {
                category = "normal";
            }
            else if (corpulenceIndex < obeseMax)
            {
                category = "overweight";
            }
            else
            {
                category = "obese";
            }

            
            Console.WriteLine($"Adults corpulence index of {corpulenceIndex} means: {category}");
        }
    }
}
