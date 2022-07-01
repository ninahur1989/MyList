using System;

namespace MyList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] b = { "32", "7777", "323" };
            ProgramLaunch<string> programLaunch = new ProgramLaunch<string>();
            programLaunch.Add1("сегодня");
            programLaunch.Add1("door");
            programLaunch.AddRange(b);
            programLaunch.Remove("32");
            programLaunch.RemoveAt(2);
            programLaunch.Sort();
            foreach (var a in programLaunch)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
