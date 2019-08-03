using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            StringBuilder replacedInput = new StringBuilder();
            replacedInput.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    replacedInput.Append(input[i]);
                }                
            }
            Console.WriteLine(replacedInput.ToString());
        }
    }
}
