using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RemBot.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        Random rnd = new Random();

        [Command("hi")]
        public async Task hello1([Remainder] string input)
        {
            Console.WriteLine(input);
            await Context.Channel.SendMessageAsync(Globals.greetings[rnd.Next(Globals.greetings.Count)]);
        }

        [Command("hello")]
        public async Task hello2()
        {
            await Context.Channel.SendMessageAsync(Globals.greetings[rnd.Next(Globals.greetings.Count)]);
        }

        [Command("HI")]
        public async Task hello3()
        {
            await Context.Channel.SendMessageAsync(Globals.greetings[rnd.Next(Globals.greetings.Count)]);
        }

        [Command("HELLO")]
        public async Task hello4()
        {
            await Context.Channel.SendMessageAsync(Globals.greetings[rnd.Next(Globals.greetings.Count)]);
        }

        [Command("Hi")]
        public async Task hello5()
        {
            await Context.Channel.SendMessageAsync(Globals.greetings[rnd.Next(Globals.greetings.Count)]);
        }

        [Command("Hello")]
        public async Task hello6()
        {
            await Context.Channel.SendMessageAsync(Globals.greetings[rnd.Next(Globals.greetings.Count)]);
        }

        [Command("Hug")]
        public async Task hug()
        {
            await Context.Channel.SendMessageAsync(Globals.hug[rnd.Next(Globals.hug.Count)]);
        }

        [Command("hug")]
        public async Task hug1()
        {
            await Context.Channel.SendMessageAsync(Globals.hug[rnd.Next(Globals.hug.Count)]);
        }

        [Command("Eromanga")]
        public async Task ero()
        {
            await Context.Channel.SendMessageAsync("I don't know anyone by that name.");
        }

        [Command("eromanga")]
        public async Task ero1()
        {
            await Context.Channel.SendMessageAsync("I don't know anyone by that name.");
        }
    }
}
