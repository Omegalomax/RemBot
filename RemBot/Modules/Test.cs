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
        public async Task hello1()
        {
            if (Globals.affectionMeter.ContainsKey(Context.User.Username))
            {
                int RemLove = Globals.affectionMeter[Context.User.Username];
                if (RemLove < 25)
                {
                    await Context.Channel.SendMessageAsync(Globals.greetings0[rnd.Next(Globals.greetings0.Count)]);
                }
                else if (RemLove < 50)
                {
                    await Context.Channel.SendMessageAsync(Globals.greetings1[rnd.Next(Globals.greetings1.Count)]);
                }
                else if (RemLove < 100)
                {
                    await Context.Channel.SendMessageAsync(Globals.greetings2[rnd.Next(Globals.greetings2.Count)]);
                }
                else if (RemLove < 200)
                {
                    await Context.Channel.SendMessageAsync(Globals.greetings3[rnd.Next(Globals.greetings3.Count)]);
                }
                else
                {
                    await Context.Channel.SendMessageAsync(Globals.greetings4[rnd.Next(Globals.greetings4.Count)]);
                }
            }
            else
            {
                await Context.Channel.SendMessageAsync(Globals.greetings0[rnd.Next(Globals.greetings0.Count)]);
            }
        }

        [Command("hello")]
        public async Task hello2()
        {
            if (Globals.affectionMeter.ContainsKey(Context.User.Username))
            {
                int RemLove = Globals.affectionMeter[Context.User.Username];
                if (RemLove < 25)
                {
                    await Context.Channel.SendMessageAsync(Globals.greetings0[rnd.Next(Globals.greetings0.Count)]);
                }
                else if (RemLove < 50)
                {
                    await Context.Channel.SendMessageAsync(Globals.greetings1[rnd.Next(Globals.greetings1.Count)]);
                }
                else if (RemLove < 100)
                {
                    await Context.Channel.SendMessageAsync(Globals.greetings2[rnd.Next(Globals.greetings2.Count)]);
                }
                else if (RemLove < 200)
                {
                    await Context.Channel.SendMessageAsync(Globals.greetings3[rnd.Next(Globals.greetings3.Count)]);
                }
                else
                {
                    await Context.Channel.SendMessageAsync(Globals.greetings4[rnd.Next(Globals.greetings4.Count)]);
                }
            }
            else
            {
                await Context.Channel.SendMessageAsync(Globals.greetings0[rnd.Next(Globals.greetings0.Count)]);
            }
        }
        
        [Command("hug")]
        public async Task hug1()
        {
            if (Globals.affectionMeter.ContainsKey(Context.User.Username))
            {
                int RemLove = Globals.affectionMeter[Context.User.Username];
                if (RemLove < 25)
                {
                    await Context.Channel.SendMessageAsync(Globals.hug0[rnd.Next(Globals.hug0.Count)]);
                }
                else if (RemLove < 50)
                {
                    await Context.Channel.SendMessageAsync(Globals.hug1[rnd.Next(Globals.hug1.Count)]);
                }
                else if (RemLove < 100)
                {
                    await Context.Channel.SendMessageAsync(Globals.hug2[rnd.Next(Globals.hug2.Count)]);
                }
                else if (RemLove < 200)
                {
                    await Context.Channel.SendMessageAsync(Globals.hug3[rnd.Next(Globals.hug3.Count)]);
                }
                else
                {
                    await Context.Channel.SendMessageAsync(Globals.hug4[rnd.Next(Globals.hug4.Count)]);
                }
            }
            else
            {
                await Context.Channel.SendMessageAsync(Globals.hug0[rnd.Next(Globals.hug0.Count)]);
            }
        }
        
        [Command("eromanga")]
        public async Task ero1()
        {
            await Context.Channel.SendMessageAsync("I don't know anyone by that name.");
        }

        [Command("eromanga sensei")]
        public async Task ero3()
        {
            await Context.Channel.SendMessageAsync("I don't know anyone by that name.");
        }
    }
}
