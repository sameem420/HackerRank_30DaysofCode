using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6___Lets_Review
{
    class Program
    {
        static void Main(String[] args)
        {

            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string S = Console.ReadLine();
                for (int j = 0; j < S.Length; j++)
                {
                    if (j % 2 == 0)
                        Console.Write(S[j]);
                }
                Console.Write(" ");
                for (var j = 0; j < S.Length; j++)
                {
                    if (j % 2 != 0)
                        Console.Write(S[j]);
                }

                Console.Write(Environment.NewLine);
            }
        }
    }
}
