using System;


namespace Udemy_course {

    class Program
    {
       static void Main(string[] args)
        {
            Cool();





        }
        public static void Cool()
        {
            Console.WriteLine("enter a number");
            string input1 = Console.ReadLine();
            Console.WriteLine("enter a Second number");
            string input2 = Console.ReadLine();
            Double num1 = int.Parse(input1);
            Double num2 = int.Parse(input2);
            double Result = num1 + num2;
            Console.WriteLine(Result);
            Console.Read();


        }




    }

        

        
    
    






};