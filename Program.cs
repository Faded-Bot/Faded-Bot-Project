using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Faded_Console.Tools;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;

namespace Faded_Console
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
            if (Directory.Exists(root))
            {
                Directory.Delete(root, true);
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
            if (option == "js")
            {
                Console.Clear();

                Konsole.WriteLine("Please Enter a Name for your Bot!");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("INPUT >>");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("$ ");
                string name = Console.ReadLine();

                Console.Clear();

                Konsole.WriteLine("Please Enter The Token for your Bot!");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("INPUT >>");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("$ ");
                string token = Console.ReadLine();

                Console.Clear();

                Konsole.WriteLine("Please Enter The Discord ID for your Bot!");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("INPUT >>");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("$ ");
                string id = Console.ReadLine();

                Console.Clear();

                Konsole.WriteLine("Please Enter a Prefix for your Bot!");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("INPUT >>");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("$ ");
                string prefix = Console.ReadLine();

                Console.Clear();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://api.project-faded.tk/api/bots"),
                    Headers =
                    {
                        { "name", name },
                        { "id", id },
                        { "prefix", prefix },
                        { "type", "js" },
                        { "owner", Environment.UserName }
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(body);
                    Thread.Sleep(4000);
                    Konsole.WriteLine("Please Wait while we are creating your bot!");
                    Console.WriteLine("");

                    if (Directory.Exists($@"{Environment.CurrentDirectory}\Faded"))
                        Thread.Sleep(1000);
                    string dir13 = $@"{Environment.CurrentDirectory}\Faded";
                    // If directory does not exist, create it
                    if (!Directory.Exists(dir13))
                    {
                        Directory.CreateDirectory(dir13);
                    }
                    Thread.Sleep(2000);

                    if (Directory.Exists($@"{Environment.CurrentDirectory}\Faded\Javascript"))
                        Thread.Sleep(1000);
                    string dir = $@"{Environment.CurrentDirectory}\Faded\Javascript";
                    // If directory does not exist, create it
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }

                    string botconfig = $@"{Environment.CurrentDirectory}\Faded\Javascript\config.json";
                    using (StreamWriter sw = File.CreateText(botconfig))
                    {
                        //sw.WriteLine("{\"prefix\":\"" + prefix + "\",\"token\":\"" + body + "\"}");
                        sw.WriteLine("{\"prefix\":\"" + prefix + "\",\"token\":\"" + token + "\"}");
                    }
                    Thread.Sleep(4000);
                    CreateJavascript.Create();
                }
            }

            if (option == "py")
            {
                Console.Clear();

                Konsole.WriteLine("Please Enter a Name for your Bot!");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("INPUT >>");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("$ ");
                string name = Console.ReadLine();

                Console.Clear();

                Konsole.WriteLine("Please Enter The Discord ID for your Bot!");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("INPUT >>");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("$ ");
                string id = Console.ReadLine();

                Console.Clear();

                Konsole.WriteLine("Please Enter a Prefix for your Bot!");
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("INPUT >>");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("$ ");
                string prefix = Console.ReadLine();

                Console.Clear();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://api.project-faded.tk/api/bots"),
                    Headers =
                    {
                        { "name", name },
                        { "id", id },
                        { "prefix", prefix },
                        { "type", "py" },
                        { "owner", Environment.UserName }
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(body);
                    Thread.Sleep(4000);
                    Konsole.WriteLine("Please Wait while we are creating your bot!");
                    Console.WriteLine("");
                    CreatePyhton.Create();
                }
            }
        }
    }
}
