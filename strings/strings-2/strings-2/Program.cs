using System;

namespace strings_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input :");
            string input = Console.ReadLine();

            input = input.ToLower();
            string replace = input.Replace("e", "@");

            Console.WriteLine("Output: {0}", replace);
            Console.ReadLine();
        }
    }
}
