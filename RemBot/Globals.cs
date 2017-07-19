using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RemBot
{
    public static class Globals
    {
        public static List<string> greetings = new List<string> { "What do *you* want.", "Don't talk to me.", "Don't you have something better to do?", "Ugh.", "You again?", "Can you make like a tree and leave.", "...", "Why are you still here", "*stare*", "Shouldn't you be doing something else?", "*ignore*" };
        public static List<string> greetings2 = new List<string> { "Hello.", "Hi.", "Yes?" };
        public static List<string> greetings3 = new List<string> { };
        public static List<string> hug = new List<string> {"Get away from me.", "Don't come any closer", "*backs away*", "What do you think you're doing?", "*readies Morningstar*", "Do you want to die?", "Back off.", "Stay away."};

        public static ConcurrentDictionary<string, int> affectionMeter;

        public static List<string> gift = new List<string> { "This is for me? ...", "Thank you.", "Thanks."};
        
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
    }
}
