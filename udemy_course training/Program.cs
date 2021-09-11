using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Udemy_course
{

    class Program
    {

        static void Main(string[] args)
        {

            try
            {
                string score = string.Empty;
                string all = string.Empty;
                do
                {
                    Console.WriteLine("enter a students name");
                    var studentsName = Console.ReadLine();
                    Console.WriteLine("enter the score");
                    var scoreLine = Console.ReadLine();
                    Console.WriteLine("Do you want to exit (Y|N)");
                    var exitAnswer = Console.ReadLine();
                    score += int.Parse(scoreLine) + " ";
                    all += studentsName + " ";

                    if (exitAnswer == "Y")
                    {
                        break;
                    }

                } while (all.Length < 20);

                Console.WriteLine(all);
                Console.WriteLine(score);
                int NewScore = int.Parse(score); 
                Console.WriteLine(NewScore);

            }
            catch (Exception)
            {
                
             
            }
            
            Console.Read();

        }

    }


}












