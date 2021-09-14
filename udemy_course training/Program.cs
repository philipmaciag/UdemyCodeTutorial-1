using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using udemy_course_training;

namespace Udemy_course
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Write something");
            string input = Console.ReadLine();
            Console.WriteLine("what sort of datatype do you want Press 1 for String Press 2 for integer Press 3 for Boolean");
            string input1 = Console.ReadLine();
            int input2 = int.Parse(input1);
            var inputedType = GuessType(input);
            switch (input2)
            {
                case 1:
                    Console.WriteLine(input2);
                    break;

                case 2:
                    if (inputedType == typeof(int))
                    {
                        Console.WriteLine(input);
                        Console.WriteLine("You Have entered a valid intiger");
                    }
                        
                    else
                    {
                        Console.WriteLine("you Have entered a non-valid intiger");
                    }
                    break;

                case 3:
                    if (inputedType == typeof(bool))
                    {
                        Console.WriteLine(input);
                        Console.WriteLine("you have entered a valid bool");

                    } else
                    {
                        Console.WriteLine("you have entered a non-valid bool");

                    }
                        break;

                


            }

            static Type GuessType(string input)
            {
                if (int.TryParse(input, out var n))
                {
                    return typeof(int);
                } else if(bool.TryParse(input, out var b))
                {
                    return typeof(bool);
                }else
                {
                    return typeof(string);

                }


            }



        }

    }


}












