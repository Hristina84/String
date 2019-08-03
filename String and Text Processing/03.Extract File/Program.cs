using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split("\\").ToArray();
            var nameAndExtension = input[input.Length - 1].Split('.');
            Console.WriteLine($"File name: {nameAndExtension[0]}");
            Console.WriteLine($"File extension: {nameAndExtension[1]}");
        }
    }
}
