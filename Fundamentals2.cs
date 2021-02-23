using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Fundamentals2
    {
        static void Main (string[] args)
        {
            int userNumberInput = 0;
            int userNumberSum = 0;
            int greatestUserNumber = 0;
            
            Console.WriteLine("Please provide a number between 0 and 20");
            string userInput = Console.ReadLine();

            do
            {
                if (int.TryParse(userInput, out userNumberInput))
                {
                    if (userNumberInput == 0)
                    {
                        Console.WriteLine("The highest number supplied: " + greatestUserNumber + "\nThe total sum of all numbers supplied: " + userNumberSum);
                        break;
                    }
                    else if (userNumberInput > 20 || userNumberInput < 0)
                    {
                        Console.WriteLine("The number you supplied exceeds the allowed range. Please input between 0 and 20.");
                        Console.WriteLine("Please provide a number between 0 and 20");
                        userInput = Console.ReadLine();
                    }
                    else if (!int.TryParse(userInput, out userNumberInput))
                    {
                        Console.WriteLine("Please only supply number types within the required range.");
                        Console.WriteLine("Please provide a number between 0 and 20");
                        userInput = Console.ReadLine();
                    }
                    else
                    {
                        userNumberSum += userNumberInput;
                        Console.WriteLine(userNumberSum);
                        Console.WriteLine("Please provide a number between 0 and 20");
                        userInput = Console.ReadLine();
                        if (userNumberInput > greatestUserNumber)
                        {
                            greatestUserNumber = userNumberInput;
                        }
                    }
                } 
            } while (userNumberInput > 0 || userNumberInput <= 20);
        }
    }
}
