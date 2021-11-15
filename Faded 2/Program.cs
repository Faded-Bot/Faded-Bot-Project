using System;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Faded_2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Title = "Loading...";
            DirectoryInfo di = new DirectoryInfo(@"C:\Faded");
            string root = @"C:\Faded";
            // If directory does not exist, create it. 
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

            if (Directory.Exists($"{Environment.CurrentDirectory}\\Faded"))
            Thread.Sleep(1000);
            string dir6 = $@"{Environment.CurrentDirectory}\Faded";
            // If directory does not exist, create it
            if (!Directory.Exists(dir6))
            {
                Directory.CreateDirectory(dir6);
            }
            Thread.Sleep(2000);

            if (Directory.Exists($"{Environment.CurrentDirectory}\\Faded\\Bots\\panel"))
            Thread.Sleep(1000);
            string dir5 = $@"{Environment.CurrentDirectory}\Faded\Bots\panel";
            // If directory does not exist, create it
            if (!Directory.Exists(dir5))
            {
                Directory.CreateDirectory(dir5);
            }

            Console.Title = "Faded Bot Project";
            WebClient webClient5 = new WebClient();

            await webClient5.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/website.txt", $"{Environment.CurrentDirectory}\\Faded\\Bots\\panel" + "\\usebot.js.html");
            await webClient5.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/website2.txt", $"{Environment.CurrentDirectory}\\Faded\\Bots\\panel" + "\\usebot.py.html");

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
                if (Directory.Exists($"{Environment.CurrentDirectory}\\Faded")) { di.Delete(true); }
                Thread.Sleep(1000);
                string dir13 = $@"{Environment.CurrentDirectory}\Faded";
                // If directory does not exist, create it
                if (!Directory.Exists(dir13))
                {
                    Directory.CreateDirectory(dir13);
                }
                Thread.Sleep(2000);

                if (Directory.Exists($"{Environment.CurrentDirectory}\\Faded\\python")) { di.Delete(true); }
                Thread.Sleep(1000);
                string dir11 = $@"{Environment.CurrentDirectory}\Faded\python";
                // If directory does not exist, create it
                if (!Directory.Exists(dir11))
                {
                    Directory.CreateDirectory(dir11);
                }
                Thread.Sleep(2000);

                if (Directory.Exists($"{Environment.CurrentDirectory}\\Faded\\python\\cogs")) { di.Delete(true); }
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
                Console.WriteLine($"[+] Writing Python File!");
                Console.WriteLine("");
                using (var progress = new ProgressBar())
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        progress.Report((double)i / 100);
                        Thread.Sleep(20);
                    }
                }

                WebClient webClient = new WebClient();

                await webClient.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/python/botpy.txt", $"{Environment.CurrentDirectory}\\Faded\\python" + "\\main.py");
                Thread.Sleep(1000);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Writing Keep Alive file!");
                Console.WriteLine("");
                using (var progress = new ProgressBar())
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        progress.Report((double)i / 100);
                        Thread.Sleep(20);
                    }
                }
                await webClient.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/python/alive.txt", $"{Environment.CurrentDirectory}\\Faded\\python" + "\\keep_alive.py");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Writing Command file!");
                Console.WriteLine("");
                using (var progress = new ProgressBar())
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        progress.Report((double)i / 100);
                        Thread.Sleep(20);
                    }
                }
                await webClient.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/python/cog.txt", $"{Environment.CurrentDirectory}\\Faded\\python\\cogs" + "\\cog_example.py");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] DONE WRITING FILES");
                Console.WriteLine("");
                Thread.Sleep(2000);
                Console.WriteLine($"[+] TO USE THE BOT Go to Faded/Bots/panel/usebot.py!");
                Console.WriteLine("");
                Thread.Sleep(4000);
                Console.Title = "Faded Bot Project";
                Console.Clear();
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
                if (Directory.Exists($"{Environment.CurrentDirectory}\\Faded\\Javascript")) { di.Delete(true); }
                Thread.Sleep(1000);
                string dir = $@"{Environment.CurrentDirectory}\Faded\Javascript";
                // If directory does not exist, create it
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                Console.Title = "Please do not Close me!";
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[+] Writing Javascript File");
                Console.WriteLine("");
                using (var progress = new ProgressBar())
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        progress.Report((double)i / 100);
                        Thread.Sleep(20);
                    }
                }
                WebClient webClient = new WebClient();

                await webClient.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/v13/bot.txt", $"{Environment.CurrentDirectory}\\Faded\\Javascript" + "\\bot.js");
                Thread.Sleep(1000);
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Writing config file!");
                Console.WriteLine("");
                using (var progress = new ProgressBar())
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        progress.Report((double)i / 100);
                        Thread.Sleep(20);
                    }
                }
                Thread.Sleep(3000);
                await webClient.DownloadFileTaskAsync("https://fadedlol.zzerzv.repl.co/v13/config.txt", $"{Environment.CurrentDirectory}\\Faded\\Javascript" + "\\config.json");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Writing files!");
                using (var progress = new ProgressBar())
                {
                    for (int i = 0; i <= 100; i++)
                    {
                        progress.Report((double)i / 100);
                        Thread.Sleep(20);
                    }
                }
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[+] DONE WRITING FILES!");
                Console.WriteLine("");
                Thread.Sleep(2000);
                Console.WriteLine($"[+] TO USE THE BOT Go to Faded/Bots/panel/usebot.js!");
                Console.WriteLine("");
                Thread.Sleep(4000);
                Console.Title = "Faded Bot Project";
                Console.Clear();
                Thread.Sleep(4000);
                Console.WriteLine("[+] Thank you for using Faded!");
                Console.WriteLine("");
                Thread.Sleep(3000);
                Console.WriteLine("[+] Made by zzerzv#2216 !");
                Thread.Sleep(10000);
                Console.WriteLine("");
            }
        }
    }
}
