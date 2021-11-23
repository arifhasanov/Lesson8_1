using System;

namespace Lesson8_1
{
    class Program
    {
        static void Main(string[] args)
        {

            if (string.IsNullOrEmpty(Properties.Settings1.Default.UserName))
            {
                Console.WriteLine("Please enter username:");
                Properties.Settings1.Default.UserName = Console.ReadLine();
            }

            if (string.IsNullOrEmpty(Properties.Settings1.Default.Job))
            {
                Console.WriteLine("Please enter job:");
                Properties.Settings1.Default.Job = Console.ReadLine();
            }

            Properties.Settings1.Default.Save();

            string userName = Properties.Settings1.Default.UserName;
            string job = Properties.Settings1.Default.Job;
            string greeting = Properties.Settings1.Default.Greetings;
            Console.WriteLine($"{greeting}, {job} {userName}!");

            Console.WriteLine("If you want to clear settings values enter 'CLEAR' and press ENTER");
            if(Console.ReadLine() == "CLEAR")
            {
                Properties.Settings1.Default.Job = "";
                Properties.Settings1.Default.UserName = "";
                Properties.Settings1.Default.Save();
                Console.WriteLine("Settings values are cleared! Re-run the program to enter new values. Bye!");
            }

            Console.Read();

        }
    }
}
