using System;

namespace Lab_5.Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string numbers = string.Empty;
            string letters = string.Empty;
            string symbols = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] > 48 && text[i] < 58)
                {
                    numbers += text[i];
                }
                else if (text[i] > 64 && text[i] < 91 || text[i] > 96 && text[i] < 123)
                {
                    letters += text[i];
                }
                else
                {
                    symbols += text[i];
                }
            }
            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
