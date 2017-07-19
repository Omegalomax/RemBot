using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RemBot
{
    public static class Globals
    {
        public static List<string> greetings0 = new List<string> { "What do *you* want.", "Don't talk to me.", "Don't you have something better to do?", "Ugh.", "You again?", "Can you make like a tree and leave.", "...", "Why are you still here", "*stare*", "Shouldn't you be doing something else?", "*ignore*" };
        public static List<string> greetings1 = new List<string> { "Oh, it's you.", "Hey...", "Huh?", "Aren't you..." };
        public static List<string> greetings2 = new List<string> { "Hello.", "Hi.", "Yes?" };
        public static List<string> greetings3 = new List<string> { "Hello %Name%!", "Ohayo!", "Hello!", "Hey! How's it going?" };
        public static List<string> greetings4 = new List<string> { };

        public static List<string> joke0 = new List<string> { };
        public static List<string> joke1 = new List<string> { };
        public static List<string> joke2 = new List<string> { };
        public static List<string> joke3 = new List<string> { };
        public static List<string> joke4 = new List<string> { };

        public static List<string> howareyou0 = new List<string> { "What's it matter to you?", "*Cold Shoulder*" };
        public static List<string> howareyou1 = new List<string> { };
        public static List<string> howareyou2 = new List<string> { };
        public static List<string> howareyou3 = new List<string> { };
        public static List<string> howareyou4 = new List<string> { "Wonderful, as long as you're here!" };

        public static List<string> askabouther0 = new List<string> { };
        public static List<string> askabouther1 = new List<string> { };
        public static List<string> askabouther2 = new List<string> { };
        public static List<string> askabouther3 = new List<string> { };
        public static List<string> askabouther4 = new List<string> { };

        public static List<string> compliment0 = new List<string> { };
        public static List<string> compliment1 = new List<string> { };
        public static List<string> compliment2 = new List<string> { };
        public static List<string> compliment3 = new List<string> { };
        public static List<string> compliment4 = new List<string> { };

        public static List<string> praise0 = new List<string> { };
        public static List<string> praise1 = new List<string> { };
        public static List<string> praise2 = new List<string> { };
        public static List<string> praise3 = new List<string> { };
        public static List<string> praise4 = new List<string> { };

        public static List<string> hug0 = new List<string> {"Get away from me.", "Don't come any closer", "*backs away*", "What do you think you're doing?", "*readies Morningstar*", "Do you want to die?", "Back off.", "Stay away."};
        public static List<string> hug1 = new List<string> { "Huh? Hug you?", "Let's not...", };
        public static List<string> hug2 = new List<string> { };
        public static List<string> hug3 = new List<string> { };
        public static List<string> hug4 = new List<string> { };

        public static List<string> pet0 = new List<string> { };
        public static List<string> pet1 = new List<string> { };
        public static List<string> pet2 = new List<string> { };
        public static List<string> pet3 = new List<string> { };
        public static List<string> pet4 = new List<string> { };

        public static List<string> kiss0 = new List<string> { "*Shoves her heel in your face*", "I think... I'm going to be sick..", "http://i.imgur.com/DFz4FsK.gifv"};
        public static List<string> kiss1 = new List<string> { "Huh..? What the..." };
        public static List<string> kiss2 = new List<string> { };
        public static List<string> kiss3 = new List<string> { };
        public static List<string> kiss4 = new List<string> { };

        public static List<string> wave0 = new List<string> { };
        public static List<string> wave1 = new List<string> { };
        public static List<string> wave2 = new List<string> { };
        public static List<string> wave3 = new List<string> { };
        public static List<string> wave4 = new List<string> { };

        public static List<string> weather0 = new List<string> { };
        public static List<string> weather1 = new List<string> { };
        public static List<string> weather2 = new List<string> { };
        public static List<string> weather3 = new List<string> { };
        public static List<string> weather4 = new List<string> { };

        public static List<string> gift0 = new List<string> { "No.", "*Grabs your gift and throws it at the trash*", "*Turns and walks away*" };
        public static List<string> gift1 = new List<string> { "I... don't think so..", };
        public static List<string> gift2 = new List<string> { "This is for me? ...", "Thank you.", "Thanks." };
        public static List<string> gift3 = new List<string> { };
        public static List<string> gift4 = new List<string> { };

        public static ConcurrentDictionary<string, int> affectionMeter;

        public static void persistGlobals()
        {
            string outputFile = "C:\\Users\\Mochi\\Desktop\\persist.txt";
            using (var file = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
            {
                using (var sw = new StreamWriter(file))
                {
                    if (affectionMeter.Count == 0)
                        Console.WriteLine("dictionary is empty!");
                    foreach (KeyValuePair<string, int> i in affectionMeter)
                    {
                        sw.WriteLine(i.Key);
                        Console.WriteLine(i.Key);
                        sw.WriteLine(i.Value);
                        Console.WriteLine(i.Value);
                    }
                }
            }
            Console.WriteLine("persisted!");
        }

        public static void decrementRemLove()
        {
            foreach (var i in affectionMeter.ToArray())
            {
                affectionMeter[i.Key] = i.Value - 1;
                Console.WriteLine(affectionMeter[i.Key]);
            }
            Console.WriteLine("RemLove decremented!");
        }
    }
}
