using System;

namespace strings_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            bool pal = false;
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();

            input = input.ToUpper();
            int len = input.Length;

            for (i = 0; i < len / 2; i++)
            {
                if (input[i] != input[len -i  - 1])
                {
                    pal = false;
                }
                else
                {
                    pal = true;
                }
            }

            if (pal == true)
            {
                Console.WriteLine("{0} on palindromi.", input);
            }
            else
            {
                Console.WriteLine("{0} ei ole palindromi.", input);
            }

            Console.ReadLine();
        }
    }
}
