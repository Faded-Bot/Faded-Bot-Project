using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Faded.Tools;
using System.Diagnostics;
using System.Threading;

namespace Faded
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Loading...";

            DirectoryInfo di = new DirectoryInfo(@"C:\Faded");
            string root = @"C:\Faded";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            
            Thread.Sleep(4000);
            Console.Title = "Faded Bot Project";

            Konsole.WriteLine("Welcome to Faded!");
            Console.WriteLine("");
            Konsole.WriteLine("Please Type {js} or {py} to Create a Bot!");
            Console.WriteLine("");
            Konsole.Error("PLEASE NOTE WITH MAKING A DISCORD.JS BOT YOU NEED NODE v16!!");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("INPUT >>");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("$ ");

            string option = Console.ReadLine();

            if (option == null)
            {
                Console.WriteLine("");
                Konsole.Error("Invalid Command Detected Closing!");
                Thread.Sleep(4000);
                Environment.Exit(0);
            }

            if (option == "py")
            {
                CreatePyhton.Create();
            }

            if (option == "js")
            {
                
                CreateJavascript.Create();
            }

        }
    }
}
