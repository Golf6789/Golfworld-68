using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your birth year (AD): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int year))
            {
                string generation = GetGeneration(year);
                Console.WriteLine($"Your generation is: {generation}");
            }
            else
            {
                Console.WriteLine("Please enter a valid birth year!");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static string GetGeneration(int year)
        {
            if (year <= 1980)
            {
                return "Generation X (Gen X)";
            }
            else if (year >= 1981 && year <= 1996)
            {
                return "Generation Y (Millennials)";
            }
            else if (year >= 1997 && year <= 2012)
            {
                return "Generation Z (Gen Z)";
            }
            else if (year >= 2013)
            {
                return "Generation Alpha";
            }
            else
            {
                return "Unknown Generation";
            }
        }
    }
}
