using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();            
            int num1 = 0;
            int num = 0;
            if (input == "0" && n == 0)
            {
                Console.WriteLine(0);
                return;
            }
            input = input.TrimStart('0');

            for (int i = input.Length - 1; i >= 1; i--)
            {
                num = (((int)Char.GetNumericValue(input[i]) * n) + num1) % 10;
                num1 = (((int)Char.GetNumericValue(input[i]) * n) + num1) / 10;
                result.Insert(0, num);
            }
            num = ((int)Char.GetNumericValue(input[0]) * n) + num1;
            result.Insert(0, num);

            Console.WriteLine(result);

            /*
              BigInteger input = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(input * n);
            */
        }
    }
}
