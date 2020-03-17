using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1___Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "Hacker Rank ";
            // Declare second integer, double, and String variables.
            int num;
            double Number;
            string myString;
            // Read and save an integer, double, and String to your variables.
            num = Convert.ToInt32(Console.ReadLine());
            Number = Convert.ToDouble(Console.ReadLine());
            myString = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine("{0}", num + i);
            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:F1}", Number + d);
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            Console.WriteLine("{0}", s + myString);
        }
    }
}
