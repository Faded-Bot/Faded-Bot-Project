using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Diagnostics;


namespace Faded_Console.Tools
{
    internal class CreateJavascript
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

            Console.Title = "Please do not Close me!";
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Konsole.WriteLine("Writing Main File");
            Console.WriteLine("");
           
            WebClient webClient = new WebClient();

            webClient.DownloadFile("https://www.project-faded.tk/bots/V13/index.txt", $"{Environment.CurrentDirectory}\\Faded\\Javascript" + "\\index.js");
            Thread.Sleep(1000);
            Console.WriteLine("");



            Console.ForegroundColor = ConsoleColor.Green;
            Konsole.WriteLine("Writing Misc files!");
            Thread.Sleep(3000);



            webClient.DownloadFile("https://www.project-faded.tk/bots/V13/package.txt", $"{Environment.CurrentDirectory}\\Faded\\Javascript" + "\\package.json");
            Thread.Sleep(3000);



            webClient.DownloadFile("https://www.project-faded.tk/bots/V13/start.txt", $"{Environment.CurrentDirectory}\\Faded\\Javascript" + "\\start.bat");
            Thread.Sleep(3000);



            webClient.DownloadFile("https://www.project-faded.tk/bots/V13/install.txt", $"{Environment.CurrentDirectory}\\Faded\\Javascript" + "\\install.bat");
                

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Konsole.WriteLine("DONE WRITING FILES!");
            using (StreamWriter sw = File.CreateText(fileName))
            {
                Thread.Sleep(200);
                sw.WriteLine(Environment.UserName + " Executed the command \"js\" at {0}", DateTime.Now.ToString());
                Thread.Sleep(200);
                sw.WriteLine("Faded Wrote the index.js file! " + DateTime.Now.ToString());
                Thread.Sleep(200);
                sw.WriteLine("Faded Wrote the install.bat file! " + DateTime.Now.ToString());
                Thread.Sleep(200);
                sw.WriteLine("Faded Wrote the start.bat file! " + DateTime.Now.ToString());
                Thread.Sleep(200);
                sw.WriteLine("Faded Wrote the package.json file! " + DateTime.Now.ToString());
                Thread.Sleep(200);
                sw.WriteLine("Faded Wrote the config.json file! " + DateTime.Now.ToString());
                Thread.Sleep(200);
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
            Konsole.WriteLine("Made by Kumiko#0001 (https://kumiko-dev.tk)");
            Thread.Sleep(10000);
            Console.WriteLine("");

            

        }
    }
}