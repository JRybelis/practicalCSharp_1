using System;


namespace FirstProject
{
    class Fundamentals1
    {
        static void Main(string[] args)
        {
            int birthYear;
            
            Console.WriteLine("Please enter your birth year.");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out birthYear))
            {
                int age = DateTime.Now.Year - birthYear;
                Console.WriteLine("You are " + age);
            } else
            {
                Console.WriteLine("The value supplied was not a number.");
            }

            bool isUserOfLegalAge = DateTime.Now.Date.Year - birthYear > 18;

            if (isUserOfLegalAge)
            {
                Console.WriteLine("Please come in.");
            } else if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday) {
                Console.WriteLine("Oh well, it's Sunday.");
            }
            else
            {
                Console.WriteLine("Access denied.");
            }
            Console.WriteLine("Bye");

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It is the start of the week today.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("It is finally Friday.");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("The weekend has come.");
                    break;
                default:
                    Console.WriteLine("It is still the work week...");
                    break;
            }
        }
    }
}