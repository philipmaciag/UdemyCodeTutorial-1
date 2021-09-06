using System;


namespace Udemy_course {

class Program {
        
        static void Main(string[] args) {
           
            Console.WriteLine("Write your name and press enter.");
            var Name = Console.ReadLine();
            
            Console.WriteLine(Name.ToUpper());
            Console.WriteLine(Name.ToLower());
            Console.WriteLine(Name.Trim());
            Console.WriteLine(Name.Substring(2));
            Console.Read();



        }
    
    };






};