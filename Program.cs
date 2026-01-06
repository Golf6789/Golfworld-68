using System;

namespace ConsoleApp3
{
    class Program
    {
        static int water = 2000;
        static int coffee = 500;
        static int milk = 300;
        static int chocolate = 300;

        static void Main(string[] args)
        {
            int choice;

            do
            {
                ShowMenu();
                Console.Write("Select menu: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        MakeDrink(300, 20, 0, 0, "Black Coffee");
                        break;
                    case 2:
                        MakeDrink(300, 20, 0, 10, "Mocha");
                        break;
                    case 3:
                        MakeDrink(300, 20, 10, 0, "Latte");
                        break;
                    case 4:
                        MakeDrink(300, 0, 0, 20, "Chocolate");
                        break;
                    case 0:
                        Console.WriteLine("Exit program");
                        break;
                    default:
                        Console.WriteLine("Invalid menu selection");
                        break;
                }

                Console.WriteLine();
            }
            while (choice != 0);
        }

        static void ShowMenu()
        {
            Console.WriteLine("====== Automatic Coffee Machine ======");
            Console.WriteLine("1. Black Coffee");
            Console.WriteLine("2. Mocha");
            Console.WriteLine("3. Latte");
            Console.WriteLine("4. Chocolate");
            Console.WriteLine("0. Exit");
            Console.WriteLine("=====================================");
        }

        static void MakeDrink(int w, int c, int m, int ch, string name)
        {
            if (CheckIngredient(w, c, m, ch))
            {
                water -= w;
                coffee -= c;
                milk -= m;
                chocolate -= ch;

                Console.WriteLine($"Brewing {name} ... ☕");
                Console.WriteLine($"{name} is ready!");
            }
            else
            {
                Console.WriteLine("Not enough ingredients. Refilling...");
                Refill();
                Console.WriteLine("Refill completed. Please select again.");
            }
        }

        static bool CheckIngredient(int w, int c, int m, int ch)
        {
            return water >= w && coffee >= c && milk >= m && chocolate >= ch;
        }

        static void Refill()
        {
            water = 2000;
            coffee = 500;
            milk = 300;
            chocolate = 300;
        }
    }
}
