using System;

namespace silmukka_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            Random rnd = new Random();

            for (i = 1; i <= 4; i++)
            {
                Console.Write("Rivi {0}: ", i);
                for (j = 1; j <= 5; j++)
                {
                    k = rnd.Next(0, 50);
                    if (j == 5)
                    {
                        Console.Write("{0,2}\n", k);
                    }
                    else
                    {
                        Console.Write("{0,2}, ", k);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}