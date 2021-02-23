using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your birth year.");
            string userInput = Console.ReadLine();

            int birthYear = int.Parse(userInput);
            bool isUserOfLegalAge = DateTime.Now.Date.Year - birthYear > 18;

            if (isUserOfLegalAge)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
            Console.WriteLine("Bye");
        }
    }
}