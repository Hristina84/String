using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace String_and_Text_Processing
{
    class Program
    {
        static void Main()
        {
              string input = "dot net perls 867-5309?!";
              Console.WriteLine(input);

              foreach (char letter in input)
              {
                  bool isLetterOrDigit = char.IsLetterOrDigit(letter);                

                  if (char.IsLetter(letter) || char.IsDigit(letter))
                  {
                      Console.Write('*');
                  }
                  else
                  {
                      Console.Write('N');
                  }
              }

            string MyString = " Big   ";
            Console.WriteLine("Hello{0}World!", MyString); //Hello Big   World!

            string TrimString = MyString.Trim();
            Console.WriteLine("Hello{0}World!", TrimString); // HelloBigWorld!

            //string[] didimonString = Regex.Split(input, @"[A-Za-z-]+");
        }
    }
}
