using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").ToArray();           

            for (int i = 0; i < input.Length; i++)
            {
                string pass = input[i];

                if (pass.Length >= 3 && pass.Length <= 16)
                {
                    bool isLetterOrDigit = CheckIsLetterOrDigit(pass);

                    if (isLetterOrDigit)
                    {
                        Console.WriteLine(pass);
                    }                    
                }
            }
        }

        private static bool CheckIsLetterOrDigit(string pass)
        {
            foreach (char letter in pass)
            {               
                if (!char.IsLetter(letter) && !char.IsDigit(letter) && letter != '-' && letter != '_')
                {
                    return false;                    
                }                
            }
            return true;
        }
    }
}
