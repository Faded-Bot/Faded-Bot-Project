using System;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Faded
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Faded Bot Project";
            DirectoryInfo di = new DirectoryInfo(@"C:\Faded");
            string root = @"C:\Faded";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[+] Welcome to Faded!");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[+] Please Type {create.js} or {create.py} to Create a Bot!");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[-] PLEASE NOTE WITH MAKING A DISCORD.JS BOT YOU NEED NODE v16!!");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("[+] INPUT >>");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("$");

            string option = Console.ReadLine();

            if (option == null)
            {
                Console.WriteLine("");
                Console.WriteLine("[-] Invalid Command Detected Closing!");
                Thread.Sleep(4000);
                Environment.Exit(0);
            }

            if (option == "create.py")
            {
                if (Directory.Exists("C:\\Faded\\python")) { di.Delete(true); }
                Thread.Sleep(1000);
                string dir = @"C:\Faded\python";
                // If directory does not exist, create it
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                Console.Title = "Please do not move the files!";
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Writing Python File to C:/Faded/Pyhton");
                WebClient webClient = new WebClient();

                await webClient.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/python/botpy.txt", "C:\\Faded\\python" + "\\main.py");
                Thread.Sleep(3000);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Writing Keep Alive file!");
                Thread.Sleep(3000);
                await webClient.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/python/alive.txt", "C:\\Faded\\python" + "\\keep_alive.py");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Writing Command file!");
                Thread.Sleep(3000);
                if (Directory.Exists("C:\\Faded\\python\\cogs")) { di.Delete(true); }
                Thread.Sleep(1000);
                string dir1 = @"C:\Faded\python\cogs";
                // If directory does not exist, create it
                if (!Directory.Exists(dir1))
                {
                    Directory.CreateDirectory(dir1);
                }
                await webClient.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/python/cog.txt", "C:\\Faded\\python\\cogs" + "\\cog_example.py");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] DONE WRITING FILES TO C:/Faded/pyhton!");
                Console.WriteLine("");
                Thread.Sleep(2000);
                Console.Title = "Faded Bot Project";
                Console.Clear();
                Thread.Sleep(3000);
                Console.WriteLine("[+] YOU CAN NOW MOVE THE FILES!!");
                Console.WriteLine("");
                Thread.Sleep(4000);
                Console.WriteLine("[+] Thank you for using Faded!");
                Console.WriteLine("");
                Thread.Sleep(3000);
                Console.WriteLine("[+] Made by zzerzv#2216 !");
                Thread.Sleep(10000);
                Console.WriteLine("");
            }

            if (option == "create.js")
            {
                if (Directory.Exists("C:\\Faded\\Javascript")) { di.Delete(true); }
                Thread.Sleep(1000);
                string dir = @"C:\Faded\Javascript";
                // If directory does not exist, create it
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                if (Directory.Exists("C:\\Faded\\Javascript\\panel")) { di.Delete(true); }
                Thread.Sleep(1000);
                string dir5 = @"C:\Faded\Javascript\panel";
                // If directory does not exist, create it
                if (!Directory.Exists(dir5))
                {
                    Directory.CreateDirectory(dir5);
                }
                Console.Title = "Please do not move the files!";
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Writing Javascript File to C:/Faded/Javascript");
                WebClient webClient = new WebClient();

                await webClient.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/website.txt", "C:\\Faded\\Javascript\\panel" + "\\usebot.js.html");
                await webClient.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/website2.txt", "C:\\Faded\\Javascript\\panel" + "\\usebot.py.html");
                await webClient.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/v13/bot.txt", "C:\\Faded\\Javascript" + "\\bot.js");
                Thread.Sleep(3000);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Writing config file!");
                Thread.Sleep(3000);
                await webClient.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/v13/config.txt", "C:\\Faded\\Javascript" + "\\config.json");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Writing files!");
                Thread.Sleep(3000);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] DONE WRITING FILES TO C:/Faded/Javascript!");
                Console.WriteLine("");
                Thread.Sleep(2000);
                Console.Title = "Faded Bot Project";
                Console.Clear();
                Thread.Sleep(3000);
                Console.WriteLine("[+] YOU CAN NOW MOVE THE FILES!!");
                Console.WriteLine("");
                Thread.Sleep(1000);
                Console.WriteLine("[+] TO USE THE BOT OPEN THE FOLDER NAMED (./panel/usebot.html)!");
                Console.WriteLine("");
                Thread.Sleep(7000);
                Console.WriteLine("[+] Thank you for using Faded!");
                Console.WriteLine("");
                Thread.Sleep(3000);
                Console.WriteLine("[+] Go to (bit.ly/31Olfyl) If you want to support me!");
                Console.WriteLine("");
                Thread.Sleep(3000);
                Console.WriteLine("[+] Made by zzerzv#2216 !");
                Thread.Sleep(10000);
                Console.WriteLine("");
            }
        }
    }
}