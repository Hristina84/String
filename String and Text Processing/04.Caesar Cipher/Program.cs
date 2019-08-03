using System;

namespace _04.Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char newLetter = (char)(input[i] + 3);
                result += newLetter;
            }
            Console.WriteLine(result);
        }
    }
}
