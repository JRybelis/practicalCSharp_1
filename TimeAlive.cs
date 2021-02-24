using System;

namespace FirstProject
{
    public class TimeAlive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day you were born on:");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the month you were born in:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your year of birth:");
            int year = int.Parse(Console.ReadLine());

            DateTime dateOfBirth = new DateTime(year, month, day);

            TimeSpan timeSpan = DateTime.Now - dateOfBirth;

            Console.WriteLine("You were born " + timeSpan.TotalDays + "days ago");
        }
    }
}
