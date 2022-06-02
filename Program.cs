using System;

namespace MyList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] b = { "32", " 7777", "323" };
            ProgramLaunch programLaunch = new ProgramLaunch();
            programLaunch.Add("сегодня");
            programLaunch.AddRange(b);
            programLaunch.Remove("32");
            programLaunch.RemoveAt(1);
            programLaunch.Sort();
            foreach (var a in programLaunch)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();
        }
    }
}
