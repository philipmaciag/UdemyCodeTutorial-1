using System;


namespace Udemy_course {
static class Extend
    {

        public static string CapitaliseFirst(this string x)
        {
            var firstLetterOfFirstName = x.Substring(0, 1);
            firstLetterOfFirstName = firstLetterOfFirstName.ToUpper();
            var restOfLettersInFirstName = x.Substring(1);
            var BetterFirstName = firstLetterOfFirstName + restOfLettersInFirstName;
            return BetterFirstName;
        }




    }
class Program {
        
        static void Main(string[] args) {
           
            Console.WriteLine("Write a String and press enter.");
            var mystring = Console.ReadLine();
            Console.WriteLine("enter a character to search");
            char my_second_string = (char)Console.Read();
            Console.ReadLine();
            Console.WriteLine(mystring.IndexOf(my_second_string));
            Console.WriteLine("Enter your first Name");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter your last Name");
            var lastName = Console.ReadLine();

            Console.WriteLine(firstName.CapitaliseFirst());
            Console.WriteLine(lastName.CapitaliseFirst());
            Console.Read();
        }

        
    
    };






};