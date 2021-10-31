using System;
using System.Text.RegularExpressions;

namespace Homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The valid format is +XX YYY-YYY-YYY !");
            Console.WriteLine("Please input your phone number: ");
            string number = Console.ReadLine();
            string pattern1 = @"[+]\d+\s\d+[-]\d+[-]\d+";

            var rgx = new Regex(pattern1);
            Match output = Regex.Match(number, pattern1);

            if (rgx.IsMatch(number))
            {
                Console.WriteLine($"True");
            }
            else
            {
                Console.WriteLine($"False");
            }
            Console.ReadLine();
        }
        
    }
}
