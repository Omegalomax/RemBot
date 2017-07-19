using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Collections.Concurrent;

namespace RemBot
{
    public class Program
    {
        static void Main(string[] args)
            => new Program().StartAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;

        private CommandHandler _handler;

        public async Task StartAsync()
        {
            
            _client = new DiscordSocketClient();

            _client.Log += Log;

            string token = "MzM2MzMyMjUwOTY0Njg4OTA3.DE9OZA.6YUDkXjNDviBYYejuRJWe4dnUzg";
            await _client.LoginAsync(TokenType.Bot, token);

            await _client.StartAsync();

            _handler = new CommandHandler(_client);


            Globals.affectionMeter = new ConcurrentDictionary<string, int>();
            string inputFile = "C:\\Users\\Mochi\\Desktop\\persist.txt";

            if (new FileInfo(inputFile).Length != 0)
            {
                using (var file = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                {
                    using (var sr = new StreamReader(file))
                    {
                        string userName = sr.ReadLine();
                        int remLove = Int32.Parse(sr.ReadLine());
                        Globals.affectionMeter.AddOrUpdate(userName, remLove, (key, value) => value = 0);
                    }
                }
            }

            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromMinutes(1);

            var timer = new System.Threading.Timer((e) =>
            {
                Globals.persistGlobals();
            }, null, startTimeSpan, periodTimeSpan);


            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}