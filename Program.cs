using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("กรุณาป้อนตัวเลข (คั่นด้วยช่องว่าง):");
            string input = Console.ReadLine();

            List<double> numbers = input
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            Console.WriteLine($"ค่าเฉลี่ย: {Average(numbers)}");
            Console.WriteLine($"ค่าสูงสุด: {Max(numbers)}");
            Console.WriteLine($"ค่าต่ำสุด: {Min(numbers)}");
            Console.WriteLine($"ค่ากลางข้อมูล (Median): {Median(numbers)}");

            Console.WriteLine("\nเรียงจากมากไปน้อย:");
            DisplayDescending(numbers);

            Console.WriteLine("\nเรียงจากน้อยไปมาก:");
            DisplayAscending(numbers);

            Console.ReadLine();
        }

        // ค่าเฉลี่ย
        static double Average(List<double> nums)
        {
            return nums.Average();
        }

        // ค่าสูงสุด
        static double Max(List<double> nums)
        {
            return nums.Max();
        }

        // ค่าต่ำสุด
        static double Min(List<double> nums)
        {
            return nums.Min();
        }

        // ค่ากลางข้อมูล (Median)
        static double Median(List<double> nums)
        {
            var sorted = nums.OrderBy(n => n).ToList();
            int count = sorted.Count;

            if (count % 2 == 0)
                return (sorted[count / 2 - 1] + sorted[count / 2]) / 2;
            else
                return sorted[count / 2];
        }

        // เรียงจากน้อยไปมาก
        static void DisplayAscending(List<double> nums)
        {
            foreach (var n in nums.OrderBy(n => n))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

        // เรียงจากมากไปน้อย
        static void DisplayDescending(List<double> nums)
        {
            foreach (var n in nums.OrderByDescending(n => n))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
