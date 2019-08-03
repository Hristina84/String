using System;

namespace Lab_4.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                string banWord = input[i];
                var wordToReplaceWith = new string ('*', banWord.Length);
                text = text.Replace(banWord, wordToReplaceWith);
            }
            Console.WriteLine(text);
        }
    }
}
