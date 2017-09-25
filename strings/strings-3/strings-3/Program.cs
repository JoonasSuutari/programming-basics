using System;

namespace strings_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int o = 0;
            int i, len;

            Console.WriteLine("Input: ");
            string input = Console.ReadLine();

            input = input.ToLower();
            len = input.Length;

            for (i = 0; i < len; i++)
                if (input[i] == 'l')
                {
                    o++;
                }

            Console.WriteLine("Output: Syötteessä on {0} l kirjainta.", o);
            Console.ReadLine();
        }
    }
}
