using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2___Operators
{
    class Program
    {
        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tip = meal_cost * (Convert.ToDouble(tip_percent) / 100);
            double tax = meal_cost * (Convert.ToDouble(tax_percent) / 100);
            double totalCost = meal_cost + tip + tax;
            Console.WriteLine("{0}", Math.Round(totalCost));
        }

        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            int tip_percent = Convert.ToInt32(Console.ReadLine());

            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
