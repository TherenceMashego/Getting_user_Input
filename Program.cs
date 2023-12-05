using System;

namespace Getting_user_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt user for name input
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hi " + name);

            // Prompt user for age input
            Console.Write("How old are you? ");
            // The values from the user are always strings
            string age = Console.ReadLine();
            Console.WriteLine("You are " + age + " years old.");

            Console.ReadLine();
        }
    }
}
