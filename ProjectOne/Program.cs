using System;

namespace ProjectOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Cool, nice to meet you {name}.");
            Console.WriteLine($"{name}, how old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Wow! {age} years old. My oh my how time passes {name}.");
            Console.WriteLine("Let me add up how old you will be in the future. Enter the amount of year(s).");
            int years = int.Parse(Console.ReadLine());
            int newAge = age + years;
            Console.WriteLine($"This is how old you will be in {years} year(s): {newAge}");
            Console.WriteLine("Do you want to continue this conversation? Y/N");
            
            ConsoleKeyInfo userChoice = Console.ReadKey(true);
            Console.WriteLine($"Goodbye!");
            

            // var x = userChoice.Key;
            // char y = userChoice.KeyChar;
            // var z = userChoice.Modifiers;

            // Console.WriteLine("Key: " +x);
            // Console.WriteLine("KeyChar: " +y);
            // Console.WriteLine("Modifiers: " +z);
        }
    }
}
