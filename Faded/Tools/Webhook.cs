using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Diagnostics;

namespace Faded.Tools
{
    internal class Webhook
    {
        public static void CreateWebhook()
        {
            string fileName = $@"C:\Faded\fadedweb.runtime";

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            string fileName2 = $@"C:\Faded\fadede.runtime";

            if (File.Exists(fileName2))
            {
                File.Delete(fileName2);
            }



            if (Directory.Exists($@"C:\Faded\Webhook"))
                Thread.Sleep(1000);
            string dir = $@"C:\Faded\Webhook";
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

                WebClient webClient = new WebClient();

                webClient.DownloadFile("https://www.project-faded.tk/assets/CSharpDiscordWebhook.NET.dll", $"C:\\Faded\\Webhook" + "\\CSharpDiscordWebhook.NET.dll");
                Thread.Sleep(200);
                webClient.DownloadFile("https://www.project-faded.tk/assets/Faded%20Webhook.deps.json", $"C:\\Faded\\Webhook" + "\\Faded Webhook.deps.json");
                Thread.Sleep(200);
                webClient.DownloadFile("https://www.project-faded.tk/assets/Faded%20Webhook.dll", $"C:\\Faded\\Webhook" + "\\Faded Webhook.dll");
                Thread.Sleep(200);
                webClient.DownloadFile("https://www.project-faded.tk/assets/Faded%20Webhook.exe", $"C:\\Faded\\Webhook" + "\\Faded Webhook.exe");
                Thread.Sleep(200);
                webClient.DownloadFile("https://www.project-faded.tk/assets/Faded%20Webhook.pdb", $"C:\\Faded\\Webhook" + "\\Faded Webhook.pdb");
                Thread.Sleep(200);
                webClient.DownloadFile("https://www.project-faded.tk/assets/Faded%20Webhook.runtimeconfig.dev.json", $"C:\\Faded\\Webhook" + "\\Faded Webhook.runtimeconfig.dev.json");
                Thread.Sleep(200);
                webClient.DownloadFile("https://www.project-faded.tk/assets/Faded%20Webhook.runtimeconfig.json", $"C:\\Faded\\Webhook" + "\\Faded Webhook.runtimeconfig.json");
                Thread.Sleep(200);
                webClient.DownloadFile("https://www.project-faded.tk/assets/Newtonsoft.Json.dll", $"C:\\Faded\\Webhook" + "\\Newtonsoft.Json.dll");
                Thread.Sleep(200);
                Process.Start(@"C:\Faded\Webhook\Faded Webhook.exe");
                Thread.Sleep(9000);
                using (StreamReader sr = File.OpenText(fileName2))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine("Faded has Ran into a Problem. Please Report this to the Developers. ERROR CODE: 0x2395 " + s);
                    }
                }

            Thread.Sleep(4000);
            File.Delete(@"C:\Faded\Webhook\Newtonsoft.Json.dll");
            File.Delete(@"C:\Faded\Webhook\Faded Webhook.runtimeconfig.json");
            File.Delete(@"C:\Faded\Webhook\Faded Webhook.runtimeconfig.dev.json");
            File.Delete(@"C:\Faded\Webhook\Faded Webhook.pdb");
            File.Delete(@"C:\Faded\Webhook\Faded Webhook.exe");
            File.Delete(@"C:\Faded\Webhook\Faded Webhook.dll");
            File.Delete(@"C:\Faded\Webhook\Faded Webhook.deps.json");
            File.Delete(@"C:\Faded\Webhook\CSharpDiscordWebhook.NET.dll");
        }
          
        }
    }
