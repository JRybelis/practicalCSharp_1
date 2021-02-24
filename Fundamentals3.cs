using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Fundamentals3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your gender? Please press 1 for male and 2 for female.");
            string userAnswer = Console.ReadLine();

            Gender userGender = (Gender)Enum.Parse(typeof(Gender), userAnswer);

            if (userGender == Gender.Male)
            {
                Console.WriteLine("Colonize the cosmos!");
            } else
            {
                Console.WriteLine("Turn the Earth into a Garden of Eden");
            }
        }
    }
}
