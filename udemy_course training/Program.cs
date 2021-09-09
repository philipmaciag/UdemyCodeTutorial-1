using System;
using System.Threading;

namespace Udemy_course {

    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Hello, write a Username to register it");
            string Username = Console.ReadLine();
            Console.WriteLine("enter a password and end registering");
            string Password = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("initializing...");
            Thread.Sleep(5000);
           
            Console.Clear();
            Console.WriteLine("enter your username:");
            string loggedUsername = Console.ReadLine();
            if (loggedUsername == Username)
            {
                Console.WriteLine("Enter password");
                string loggedPassword = Console.ReadLine();
                if(loggedPassword == Password)
                {
                    Console.Clear();
                    Console.WriteLine("Logging in...");
                    Thread.Sleep(5000);
                    Console.Clear();
                    Console.WriteLine("you are logged in");

                }



            };
            Console.Read();






        }

        private static void EventWaitHandle()
        {
            throw new NotImplementedException();
        }
    }

        

        
    
    






};