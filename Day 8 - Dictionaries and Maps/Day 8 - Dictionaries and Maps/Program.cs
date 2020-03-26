using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8___Dictionaries_and_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> phoneBook = new Dictionary<string, int>(N);
            for (int i = 0; i < N; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                if (temp[1].Length == 8)
                {
                    phoneBook.Add(temp[0], Convert.ToInt32(temp[1]));
                }
            }
            string nameToSearch = "";
            while ((nameToSearch = Console.ReadLine()) != null)
            {
                int flagFound = 0;
                if (nameToSearch != "")
                {
                    if (phoneBook.ContainsKey(nameToSearch))
                    {
                        flagFound = 1;
                    }
                }
                if (flagFound == 1)
                {
                    Console.WriteLine(nameToSearch + "=" + phoneBook[nameToSearch]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
