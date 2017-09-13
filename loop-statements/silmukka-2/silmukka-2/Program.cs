using System;

namespace silmukka_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;

            Console.Write("Syötä luku: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.Write("Luvun täytyy olla 1 tai suurempi.");
            }

            else
            {
                for (i = 1; i <= n; i++)
                {
                    Console.Write("{0} ", i);
                    sum += i;
                }
                Console.Write("\n");
                Console.Write("Tulos: {0}", sum);
            }
            Console.ReadLine();
        }
    }
}