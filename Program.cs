using System;
using System.Collections.Generic;

namespace Login
{
    class Program
    {
        public static Dictionary<string, string> existUsers = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            User user1 = new User();
            string answer;
            do
            {
                Console.WriteLine("New here");
                string answer1 = Console.ReadLine().ToLower();
                answer = answer1;
                if (answer == "yes")
                {
                    Console.Write("Enter your name: ");
                    string n = Console.ReadLine();
                    Console.Write("Enter your password: ");
                    string p = Console.ReadLine();
                    user1.signUp(n, p);
                }
                else if (answer == "no")
                {
                    Console.Write("Enter your name: ");
                    string n = Console.ReadLine();
                    Console.Write("Enter your password: ");
                    string p = Console.ReadLine();
                    user1.logIn(n, p);
                }
                else if (answer == "exit")
                {
                    Console.Clear();
                    break;
                }
                Console.WriteLine("=========================");
            } while (answer != "exit");
        }
    }
}
