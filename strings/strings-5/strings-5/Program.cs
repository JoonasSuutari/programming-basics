using System;

namespace strings_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int o = 0;
            int i, len;

            Console.WriteLine("Input: ");
            string input = Console.ReadLine();

            input = input.ToUpper();
            len = input.Length;

            for (i = 0; i < len; i++)
                if (input[i] == 'A' || input[i] == 'E' || input[i] == 'I' || input[i] == 'O' || input[i] == 'U' || input[i] == 'Y' || input[i] == 'Ä' || input[i] == 'Ö')
                {
                    o++;
                }

            Console.WriteLine("Output: Syötteessä {0} on {1} vokaalia.", input, o);
            Console.ReadLine();
        }
    }
}
