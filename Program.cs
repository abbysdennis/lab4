using System;

namespace Lab4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CreateMenu();
        }

        public static void CreateMenu()
        {
            string menuChoice = GetMenuChoice();

            while (menuChoice != "3")
            {
                if (menuChoice == "1")
                {
                    Console.WriteLine("Welcome to Create Triangle.");
                    CreateTriangle();
                }
                else if (menuChoice == "2")
                {
                    Console.WriteLine("Welcome to Create Number Table.");
                    CreateNumberTable();
                }

                menuChoice = GetMenuChoice();
            }

            if (menuChoice == "3")
            {
                Console.WriteLine("Thank you.  Goodbye!");
            }
        }

        public static string GetMenuChoice()
        {
            Console.WriteLine("Please select an option from the menu below:");
            Console.WriteLine("1: Create Triangle");
            Console.WriteLine("2: Create Number Table");
            Console.WriteLine("3: Exit");
            string choice = Console.ReadLine();

            while (!(choice == "1" || choice == "2" || choice == "3"))
            {
                Console.WriteLine("Please enter a valid character.");
                choice = Console.ReadLine();
            }

            return choice;
        }

        public static void CreateTriangle()
        {
            Console.WriteLine("Enter integer for the base of the triangle: ");
            int size = int.Parse(Console.ReadLine());

            for (int i = size; i >= 1; --i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("");
        }

        public static void CreateNumberTable()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.Write(i + "\t");

                for (int j = 0; j < 10; j++)
                {
                    Console.Write((i * j).ToString() + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("");
        }
    }
}
