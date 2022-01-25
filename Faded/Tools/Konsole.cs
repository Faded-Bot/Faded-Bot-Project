using System;
using System.Collections.Generic;
using System.Text;

namespace Faded.Tools
{
    internal class Konsole
    {
        public static void WriteLine(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("INFO");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);
            Console.WriteLine();
        }

        public static void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("+");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);
            Console.WriteLine();
        }
        public static void Write(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("INFO");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);
            Console.WriteLine();
        }
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("-");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);
            Console.WriteLine();
        }
    }
}