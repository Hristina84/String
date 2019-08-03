using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string ticket = input[i];

                if (ticket.Length != 20)
                {
                    Console.WriteLine($"invalid ticket");
                    continue;
                }
                var firstHalf = Regex.Matches(ticket.Substring(0, 10), @"[@#$^]+").Cast<Match>().Select(m => m.Value).ToArray();
                var secondHalf = Regex.Matches(ticket.Substring(10, 10), @"[@#$^]+").Cast<Match>().Select(m => m.Value).ToArray();

                if (firstHalf.Length == 0 || secondHalf.Length == 0 || firstHalf.Length > 1 || secondHalf.Length > 1)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                }
                string left = CreateStringFromArray(firstHalf);

                if (left.Length < 6)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
                else if (left.Length == 10 && secondHalf.Contains(left))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - 10{left[0]} Jackpot!");
                }
                else if (left.Length < 10 && secondHalf.Contains(left))
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {left.Length}{left[0]}");
                }               
            }
        }

        static string CreateStringFromArray(string[] firstHalf)
        {            
            string text = firstHalf[0];
            string longestText = string.Empty;

            for (int k = 0; k < firstHalf.Length; k++)
            {
                text = firstHalf[k];

                for (int i = 1; i < text.Length; i++)
                {
                    if (text[i] == text[i - 1])
                    {
                        continue;
                    }
                    else
                    {
                        text = string.Empty;
                    }
                }
                if (text.Length > longestText.Length)
                {
                    longestText = text;
                }
            }    
            return longestText;
        }
    }
}
