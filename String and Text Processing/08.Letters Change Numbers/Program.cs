using System;
using System.Linq;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[]{' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            decimal result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                decimal sum = 0;
                string number = input[i];
                char firstLetter = number[0];
                char lastLetter = number[number.Length - 1];
                //number = number.Substring(1, number.Length - 2);     
                
                number = string.Join("", number.Skip(1).Take(number.Length - 2));
                decimal num = decimal.Parse(number);

                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    sum += num / (firstLetter - 64);  
                }
                if (firstLetter >= 97 && firstLetter <= 122)
                {
                    sum += num * (firstLetter - 96);                  
                }
                if (lastLetter >= 65 && lastLetter <= 90)
                {                    
                    sum -= (lastLetter - 64);
                }
                if (lastLetter >= 97 && lastLetter <= 122)
                {
                    sum += (lastLetter - 96);                    
                }
                result += sum;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
