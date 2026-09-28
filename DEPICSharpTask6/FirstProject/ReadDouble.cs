using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPICSharpTask6.First_Project
{
    internal class ReadDouble
    {
       public static double ReadValidDouble(string message)
        {
            double result;
            bool isValid;

            do
            {
                Console.Write(message);
                // Using TryParse (instead of Convert/Parse directly) so invalid input never throws
                isValid = double.TryParse(Console.ReadLine(), out result);

                if (!isValid)
                    Console.WriteLine("Invalid input, please enter a number.");

            } while (!isValid);

            return result;
        }
    }
}
