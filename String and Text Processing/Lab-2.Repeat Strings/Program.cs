using System;
using System.Text;

namespace Lab_2.Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split();
            int n = strings.Length;
            string result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string word = strings[i];

                for (int j = 0; j < word.Length; j++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);

            // Better decision

             StringBuilder result1 = new StringBuilder();

            foreach (var word in strings)
            {
                int count = word.Length;

                for (int i = 0; i < count; i++)
                {
                    result1.Append(word);
                }
            }
            Console.WriteLine(result);
        }
    }
}
