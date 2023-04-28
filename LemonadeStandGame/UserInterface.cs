using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    internal static class UserInterface
    {
        public static string ValidateStringInput(string prompt, List<string> options)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower();
            while (options.Contains(input) == false)
            {
                Console.WriteLine($"Sorry {input} was not a valid options, please try again.");
                input = Console.ReadLine().ToLower();
            }
            return input;
        }
    }
}
