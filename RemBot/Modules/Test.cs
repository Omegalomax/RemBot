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
        
        
        
        
        [Command("joke")]
        public async Task joke1()
        {
            if (Globals.affectionMeter.ContainsKey(Context.User.Username))
            {
                int RemLove = Globals.affectionMeter[Context.User.Username];
                if (RemLove < 25)
                {
                    await Context.Channel.SendMessageAsync(Globals.joke0[rnd.Next(Globals.joke0.Count)]);
                }
                else if (RemLove < 50)
                {
                    await Context.Channel.SendMessageAsync(Globals.joke1[rnd.Next(Globals.joke1.Count)]);
                }
                else if (RemLove < 100)
                {
                    await Context.Channel.SendMessageAsync(Globals.joke2[rnd.Next(Globals.joke2.Count)]);
                }
                else if (RemLove < 200)
                {
                    await Context.Channel.SendMessageAsync(Globals.joke3[rnd.Next(Globals.joke3.Count)]);
                }
                else
                {
                    await Context.Channel.SendMessageAsync(Globals.joke4[rnd.Next(Globals.joke4.Count)]);
                }
            }
            else
            {
                await Context.Channel.SendMessageAsync(Globals.joke0[rnd.Next(Globals.joke0.Count)]);
            }
        }
		

		
		
[Command("compliment")]
        public async Task compliment1()
        {
            if (Globals.affectionMeter.ContainsKey(Context.User.Username))
            {
                int RemLove = Globals.affectionMeter[Context.User.Username];
                if (RemLove < 25)
                {
                    await Context.Channel.SendMessageAsync(Globals.compliment0[rnd.Next(Globals.compliment0.Count)]);
                }
                else if (RemLove < 50)
                {
                    await Context.Channel.SendMessageAsync(Globals.compliment1[rnd.Next(Globals.compliment1.Count)]);
                }
                else if (RemLove < 100)
                {
                    await Context.Channel.SendMessageAsync(Globals.compliment2[rnd.Next(Globals.compliment2.Count)]);
                }
                else if (RemLove < 200)
                {
                    await Context.Channel.SendMessageAsync(Globals.compliment3[rnd.Next(Globals.compliment3.Count)]);
                }
                else
                {
                    await Context.Channel.SendMessageAsync(Globals.compliment4[rnd.Next(Globals.compliment4.Count)]);
                }
            }
            else
            {
                await Context.Channel.SendMessageAsync(Globals.compliment0[rnd.Next(Globals.compliment0.Count)]);
            }
        }
		
		
		
		
[Command("pet")]
        public async Task pet1()
        {
            if (Globals.affectionMeter.ContainsKey(Context.User.Username))
            {
                int RemLove = Globals.affectionMeter[Context.User.Username];
                if (RemLove < 25)
                {
                    await Context.Channel.SendMessageAsync(Globals.pet0[rnd.Next(Globals.pet0.Count)]);
                }
                else if (RemLove < 50)
                {
                    await Context.Channel.SendMessageAsync(Globals.pet1[rnd.Next(Globals.pet1.Count)]);
                }
                else if (RemLove < 100)
                {
                    await Context.Channel.SendMessageAsync(Globals.pet2[rnd.Next(Globals.pet2.Count)]);
                }
                else if (RemLove < 200)
                {
                    await Context.Channel.SendMessageAsync(Globals.pet3[rnd.Next(Globals.pet3.Count)]);
                }
                else
                {
                    await Context.Channel.SendMessageAsync(Globals.pet4[rnd.Next(Globals.pet4.Count)]);
                }
            }
            else
            {
                await Context.Channel.SendMessageAsync(Globals.pet0[rnd.Next(Globals.pet0.Count)]);
            }
        }		
		
		
		
		
[Command("pat")]
        public async Task pet1()
        {
            if (Globals.affectionMeter.ContainsKey(Context.User.Username))
            {
                int RemLove = Globals.affectionMeter[Context.User.Username];
                if (RemLove < 25)
                {
                    await Context.Channel.SendMessageAsync(Globals.pet0[rnd.Next(Globals.pet0.Count)]);
                }
                else if (RemLove < 50)
                {
                    await Context.Channel.SendMessageAsync(Globals.pet1[rnd.Next(Globals.pet1.Count)]);
                }
                else if (RemLove < 100)
                {
                    await Context.Channel.SendMessageAsync(Globals.pet2[rnd.Next(Globals.pet2.Count)]);
                }
                else if (RemLove < 200)
                {
                    await Context.Channel.SendMessageAsync(Globals.pet3[rnd.Next(Globals.pet3.Count)]);
                }
                else
                {
                    await Context.Channel.SendMessageAsync(Globals.pet4[rnd.Next(Globals.pet4.Count)]);
                }
            }
            else
            {
                await Context.Channel.SendMessageAsync(Globals.pet0[rnd.Next(Globals.pet0.Count)]);
            }
        }
		
		
		
		
[Command("kiss")]
        public async Task kiss1()
        {
            if (Globals.affectionMeter.ContainsKey(Context.User.Username))
            {
                int RemLove = Globals.affectionMeter[Context.User.Username];
                if (RemLove < 25)
                {
                    await Context.Channel.SendMessageAsync(Globals.kiss0[rnd.Next(Globals.kiss0.Count)]);
                }
                else if (RemLove < 50)
                {
                    await Context.Channel.SendMessageAsync(Globals.kiss1[rnd.Next(Globals.kiss1.Count)]);
                }
                else if (RemLove < 100)
                {
                    await Context.Channel.SendMessageAsync(Globals.kiss2[rnd.Next(Globals.kiss2.Count)]);
                }
                else if (RemLove < 200)
                {
                    await Context.Channel.SendMessageAsync(Globals.kiss3[rnd.Next(Globals.kiss3.Count)]);
                }
                else
                {
                    await Context.Channel.SendMessageAsync(Globals.kiss4[rnd.Next(Globals.kiss4.Count)]);
                }
            }
            else
            {
                await Context.Channel.SendMessageAsync(Globals.kiss0[rnd.Next(Globals.kiss0.Count)]);
            }
        }
		
		
		
		
[Command("wave")]
        public async Task wave1()
        {
            if (Globals.affectionMeter.ContainsKey(Context.User.Username))
            {
                int RemLove = Globals.affectionMeter[Context.User.Username];
                if (RemLove < 25)
                {
                    await Context.Channel.SendMessageAsync(Globals.wave0[rnd.Next(Globals.wave0.Count)]);
                }
                else if (RemLove < 50)
                {
                    await Context.Channel.SendMessageAsync(Globals.wave1[rnd.Next(Globals.wave1.Count)]);
                }
                else if (RemLove < 100)
                {
                    await Context.Channel.SendMessageAsync(Globals.wave2[rnd.Next(Globals.wave2.Count)]);
                }
                else if (RemLove < 200)
                {
                    await Context.Channel.SendMessageAsync(Globals.wave3[rnd.Next(Globals.wave3.Count)]);
                }
                else
                {
                    await Context.Channel.SendMessageAsync(Globals.wave4[rnd.Next(Globals.wave4.Count)]);
                }
            }
            else
            {
                await Context.Channel.SendMessageAsync(Globals.wave0[rnd.Next(Globals.wave0.Count)]);
            }
        }
				
		
	
		
[Command("gift")]
        public async Task gift1()
        {
            if (Globals.affectionMeter.ContainsKey(Context.User.Username))
            {
                int RemLove = Globals.affectionMeter[Context.User.Username];
                if (RemLove < 25)
                {
                    await Context.Channel.SendMessageAsync(Globals.gift0[rnd.Next(Globals.gift0.Count)]);
                }
                else if (RemLove < 50)
                {
                    await Context.Channel.SendMessageAsync(Globals.gift1[rnd.Next(Globals.gift1.Count)]);
                }
                else if (RemLove < 100)
                {
                    await Context.Channel.SendMessageAsync(Globals.gift2[rnd.Next(Globals.gift2.Count)]);
                }
                else if (RemLove < 200)
                {
                    await Context.Channel.SendMessageAsync(Globals.gift3[rnd.Next(Globals.gift3.Count)]);
                }
                else
                {
                    await Context.Channel.SendMessageAsync(Globals.gift4[rnd.Next(Globals.gift4.Count)]);
                }
            }
            else
            {
                await Context.Channel.SendMessageAsync(Globals.gift0[rnd.Next(Globals.gift0.Count)]);
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
