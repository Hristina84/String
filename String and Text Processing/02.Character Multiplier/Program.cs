using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            int sum = 0;
            string firstString = input[0];
            string secondString = input[1];
            int n = Math.Min(firstString.Length, secondString.Length);            

            if (firstString.Length == secondString.Length)
            {
                sum = 0;
            }
            else
            {
                string longer = string.Empty;

                if (firstString.Length > n)
                {
                    longer = firstString.Substring(n);
                }
                else if (secondString.Length > n)
                {
                    longer = secondString.Substring(n);
                }
                foreach (var letter in longer)
                {
                    sum += (int)letter;
                }
            }         
            for (int i = 0; i < n; i++)
            {
                int number = firstString[i] * secondString[i];
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
