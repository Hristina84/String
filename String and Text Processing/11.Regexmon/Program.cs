using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _11.Regexmon
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var didimonMatches = @"[^A-Za-z-]+";
            var bojomonMatches = @"([A-Za-z]+)-([A-Za-z]+)";

            while (true)
            {
                var didimonString = Regex.Match(input, didimonMatches).ToString();

                if (didimonString != string.Empty)
                {
                    Console.WriteLine(didimonString);
                    input = TrimStringFromInput(input, didimonString);

                    var bojomonString = Regex.Match(input, bojomonMatches).ToString();

                    if (bojomonString != string.Empty)
                    {
                        Console.WriteLine(bojomonString);
                        input = TrimStringFromInput(input, bojomonString);
                    }
                }
                else
                {
                    break;
                }                
            }
        }

        static string TrimStringFromInput(string input, string matchesString)
        {
            var stringPosition = input.IndexOf(matchesString);
            var stringLenght = matchesString.Length;           
            input = input.Substring(stringPosition + stringLenght);

            return input;
        }
    }
}
