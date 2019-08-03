using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

namespace Winning_Ticket
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string token = input[i];

                if (token.Length != 20)
                {
                    Console.WriteLine($"invalid ticket");
                    continue;
                }
                else
                {
                    var firstHalf = Regex.Matches(token.Substring(0, 10), @"[@#$^]+").Cast<Match>().Select(m => m.Value).ToList();
                    var secondtHalf = Regex.Matches(token.Substring(10, 10), @"[@#$^]+").Cast<Match>().Select(m => m.Value).ToList();

                    string text = CheckIsWinner(firstHalf);

                    if (text.Length > 0)
                    {
                        foreach (var ticket in secondtHalf)
                        {
                            char sym = text[i];
                            int distinctCount = ticket.Distinct().Count();

                            int counter = 0;

                            if (ticket.Contains(sym))
                            {
                                for (int j = ticket.IndexOf(sym); j < ticket.Length; j++)
                                {
                                    if (ticket[j] == sym)
                                    {
                                        counter++;
                                    }
                                    else
                                    {
                                        counter = 0;
                                    }
                                }
                            }

                            if (ticket.Contains(text))
                            {
                                if (text.Length == 10)
                                {
                                    Console.WriteLine($"ticket \"{token}\" - {text.Length}{text[0]} Jackpot!");
                                }
                                else if (text.Length < 10)
                                {
                                    Console.WriteLine($"ticket \"{token}\" - {text.Length}{text[0]}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{token}\" - no match");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{token}\" - no match");
                    }

                }
            }
        }

        static string CheckIsWinner(List<string> firstHalf)
        {
            string text = string.Empty;
            string combination = string.Empty;

            for (int i = 0; i < firstHalf.Count; i++)
            {
                string symbols = firstHalf[i];
                combination += symbols[0];

                for (int k = 1; k < symbols.Length; k++)
                {

                    if (symbols[k] == symbols[k - 1])
                    {
                        combination += symbols[k];

                        if (combination.Length > text.Length)
                        {
                            text = combination;
                        }
                    }
                    else
                    {
                        combination = string.Empty;
                        combination += symbols[k];
                    }
                }
                if (text.Length < 6)
                {
                    text = string.Empty;
                }
            }
            return text;
        }
    }

}
