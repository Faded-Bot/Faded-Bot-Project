using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace Faded_Console.Tools
{
    internal class CreatePyhton
    {
        public static void Create()
        {
            string fileName = $@"C:\Faded\faded.runtime";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            string fileName2 = $@"C:\Faded\fadede.runtime";

            if (File.Exists(fileName2))
            {
                File.Delete(fileName2);
            }



            if (Directory.Exists($@"{Environment.CurrentDirectory}\Faded"))
            Thread.Sleep(1000);
            string dir13 = $@"{Environment.CurrentDirectory}\Faded";
            // If directory does not exist, create it
            if (!Directory.Exists(dir13))
            {
                Directory.CreateDirectory(dir13);
            }
            Thread.Sleep(2000);

            if (Directory.Exists($@"{Environment.CurrentDirectory}\Faded\python"))
            Thread.Sleep(1000);
            string dir11 = $@"{Environment.CurrentDirectory}\Faded\python";
            // If directory does not exist, create it
            if (!Directory.Exists(dir11))
            {
                Directory.CreateDirectory(dir11);
            }
            Thread.Sleep(2000);

            if (Directory.Exists($@"{Environment.CurrentDirectory}\Faded\python\cogs"))
            Thread.Sleep(1000);
            string dir12 = $@"{Environment.CurrentDirectory}\Faded\python\cogs";
            // If directory does not exist, create it
            if (!Directory.Exists(dir12))
            {
                Directory.CreateDirectory(dir12);
            }

            Thread.Sleep(2000);
            Console.Title = "Please do not close me!";
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Konsole.WriteLine("Writing Python File!");
            Console.WriteLine("");
            Thread.Sleep(4000);

            WebClient webClient = new WebClient();

            webClient.DownloadFile("https://www.project-faded.tk/bots/python/botpy.txt", $"{Environment.CurrentDirectory}\\Faded\\python" + "\\main.py");
            Thread.Sleep(4000);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Konsole.WriteLine("Writing Keep Alive file!");
            Console.WriteLine("");
            webClient.DownloadFile("https://www.project-faded.tk/bots/python/alive.txt", $"{Environment.CurrentDirectory}\\Faded\\python" + "\\keep_alive.py");
            Thread.Sleep(4000);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Konsole.WriteLine("Writing Command file!");
            Console.WriteLine("");
            webClient.DownloadFile("https://www.project-faded.tk/bots/python/cog.txt", $"{Environment.CurrentDirectory}\\Faded\\python\\cogs" + "\\cog_example.py");
            Thread.Sleep(4000);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;

            Konsole.WriteLine("DONE WRITING FILES!");
            using (StreamWriter sw = File.CreateText(fileName))
            {
                Thread.Sleep(200);
                sw.WriteLine(Environment.UserName + " Executed the command \"py\" at {0}", DateTime.Now.ToString());
                Thread.Sleep(200);
                sw.WriteLine("Faded Wrote the main.py file! " + DateTime.Now.ToString());
                Thread.Sleep(200);
                sw.WriteLine("Faded Wrote the keep_alive.py file! " + DateTime.Now.ToString());
                Thread.Sleep(200);
                sw.WriteLine("Faded Wrote the cog_example.py file! " + DateTime.Now.ToString());
                AppDomain.CurrentDomain.UnhandledException += (sender, eventArgs) =>
                {
                    sw.WriteLine("Faded Found a Error! " + Environment.UserName + "'s pc encounted a error. The error is: " + eventArgs.ExceptionObject.ToString());
                };
            }

            AppDomain.CurrentDomain.UnhandledException += (sender, eventArgs) =>
            {
                using (StreamWriter sw = File.CreateText(fileName2))
                {
                    sw.WriteLine(eventArgs.ExceptionObject.ToString());
                }

            };



            Console.WriteLine("");
            Thread.Sleep(2000);
            Console.Title = "Faded Bot Project";
            Console.Clear();
            Thread.Sleep(4000);
            Konsole.WriteLine("Thank you for using Faded!");
            Console.WriteLine("");
            Thread.Sleep(3000);
            Konsole.WriteLine("Made by Vexi#0001");
            Thread.Sleep(10000);
            Console.WriteLine("");


        }
    }
}