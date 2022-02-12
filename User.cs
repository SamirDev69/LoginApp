using System;
using System.Collections.Generic;

namespace Login
{

    class User
    {
        string userName, Password;
        public void signUp(string name, string password)
        {
            if (Program.existUsers.ContainsKey(name) || Program.existUsers.ContainsValue(password))
            {
                Console.WriteLine("Password or name already exists.");
            }
            else
            {
            userName = name;
            Password = password;
            Program.existUsers.Add(name, password);
            }
        }
        public void logIn(string name, string password){
            if (Program.existUsers.ContainsKey(name) && Program.existUsers.ContainsValue(password))
            {
                Console.WriteLine($"Welcome Back {name}");
            }
            else
            {
                Console.WriteLine("User name or password incorrect");
            }
        }
    }


}