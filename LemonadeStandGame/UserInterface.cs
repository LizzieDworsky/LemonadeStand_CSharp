using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    internal static class UserInterface
    {
        public static char ValidateCharInput(string prompt, List<char> options)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower();
            char result;
            while (char.TryParse(input, out result) == false || options.Contains(result) == false)
            {
                Console.WriteLine($"Sorry {input} was not a valid option, please try again.");
                input = Console.ReadLine().ToLower();
            }
            return result;
        }

        public static int ValidateIntInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            int result;
            while (int.TryParse(input, out result) == false)
            {
                Console.WriteLine($"Sorry {input} was not a valid option, please try again.");
                input = Console.ReadLine();
            }
            return result;
        }

        public static string FormatDouble(double toFormat)
        {
            string formatted = toFormat.ToString("0.00");
            return formatted;
        }
    }
}
