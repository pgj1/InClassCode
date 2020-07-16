using System;

namespace NewTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Second line of code");
            Console.WriteLine("Third line of code");
            Console.WriteLine("Forth line of code");
            // comment line


            /*  Multi comment Line
               line 2 of comment 
              Line 3  */
            Console.Write("Hello");
            Console.Write(" Class!");

            //Lesson 2.3  Casting from a string to an integer. 
            string notANumber = "199";
            int results = 19 * int.Parse(notANumber);
            Console.WriteLine(" ");
            Console.Write("Results = ");
            Console.WriteLine(results);
            /*  DATA TYPES
             *  string
                char
                int
                double
                float
                bool
                uint
                long
                DateTime
             
             */
        }

    }
}
