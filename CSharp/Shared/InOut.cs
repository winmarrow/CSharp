using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class InOut
    {
        public const ConsoleColor ConsoleInputColor = ConsoleColor.Blue;
        public const ConsoleColor ConsoleOutputColor = ConsoleColor.DarkGreen;

        public static string GetStringFromConsole(string message)
        {
            ConsoleColor previosConsoleOutputColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleOutputColor;
            Console.Write($"{message}: ");

            Console.ForegroundColor = ConsoleInputColor;
            string str = Console.ReadLine();

            Console.ForegroundColor = previosConsoleOutputColor;
            return str;
        }

    }
}
