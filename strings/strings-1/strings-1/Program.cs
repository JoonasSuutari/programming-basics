using System;

namespace strings_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int o = 0;
            string i;

            Console.WriteLine("Input: ");
            i = Console.ReadLine();

            foreach (char chr in i)
            {
                o += 1;
            }

            Console.WriteLine("Output: Syötteessä on {0} merkkiä.", o);
            Console.ReadLine();
        }
    }
}
