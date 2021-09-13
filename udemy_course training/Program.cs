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
            for (int i = 0; i < 2; i++) {
            Console.WriteLine("enter your gun name");
            string GN = Console.ReadLine();
            Console.WriteLine("enter your gun damage");
            string GD = Console.ReadLine();
            Console.WriteLine("enter your gun speed");
            string GS = Console.ReadLine();
            int GDI;
            int GSI;
            bool t = int.TryParse(GD, out GDI);
            if (t)
            {
                GDI = int.Parse(GD);
            } else
            {
                throw new ArgumentException("Gun Damage is a Word/Letter");


            }

            bool t2 = int.TryParse(GS, out GSI);
            if (t2)
            {
                GSI = int.Parse(GS);

            } else
            {
                throw new ArgumentException("Gun Speed is a Word/Letter");

            }

                Gun g + i.ToString() = new Gun(GN, GDI, GSI);
            g.DisplayInfo();
               
            }
            
            
            
            

        }

    }


}












