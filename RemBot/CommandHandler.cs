using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace RemBot
{
    public class CommandHandler
    {
        private DiscordSocketClient _client;

        private CommandService _service;

        public CommandHandler(DiscordSocketClient client)
        {
            _client = client;

            _service = new CommandService();

            _service.AddModulesAsync(Assembly.GetEntryAssembly());

            _client.MessageReceived += HandleCommandAsync;
        }

        private async Task HandleCommandAsync(SocketMessage s)
        {
            var msg = s as SocketUserMessage;
            if (msg == null)
                return;

            var context = new SocketCommandContext(_client, msg);

            Console.WriteLine(msg.Content);

            //test
            ulong id = msg.Author.Id;
            Console.WriteLine(id);

            string userName = _client.GetUser(id).Username;
            Console.WriteLine(userName);

            int argPos = 0;
            if (msg.HasCharPrefix('!', ref argPos) || msg.HasMentionPrefix(_client.CurrentUser, ref argPos))
            {
                var result = await _service.ExecuteAsync(context, argPos);

                Globals.affectionMeter.AddOrUpdate(userName, 1, (key, value) => value + 1);

                if (!result.IsSuccess)
                {
                    string reply = "Don't talk to me.";
                    if (result.Error != CommandError.UnknownCommand)
                        reply = result.ErrorReason;
                    await context.Channel.SendMessageAsync(reply);
                }
            }
        }
    }
}
