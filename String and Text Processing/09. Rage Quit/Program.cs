using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace _09._Rage_Quit
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = @"(([^\d]+)(\d+))";
            int symbols = 0;
                        
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                string letters = match.Groups[2].Value;
                int num = int.Parse(match.Groups[3].Value);

                for (int i = 0; i < num; i++)
                {
                    result.Append(letters);
                }
            }

            symbols = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {symbols}");
            Console.WriteLine(result);
        }

        
    }
}
