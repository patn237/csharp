using System;

namespace GameShow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello and welcome to my game show!");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Please choose between door number 1, door number 2, or door number 3.");
            Console.WriteLine();
            Console.WriteLine("Door Number 1 - Press 1");
            Console.WriteLine("Door Number 2 - Press 2");
            Console.WriteLine("Door Number 3 - Press 3");

            ConsoleKeyInfo selection = Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine($"You have selected door number {selection.KeyChar}!");
            if (selection.KeyChar.Equals('1'))
            {
                DoorOne();
            }
            if (selection.KeyChar.Equals('2'))
            {
                DoorTwo();
            }
            if (selection.KeyChar.Equals('3'))
            {
                DoorThree();
            }

        }

        public static void DoorOne()
        {
            Console.WriteLine("You have won a brand new car!");
        }

        public static void DoorTwo()
        {
            Console.WriteLine("You have won $10,000!");
        }

        public static void DoorThree()
        {
            Console.WriteLine("You have won a vacation to Hawaii!");
        }
    }
}
