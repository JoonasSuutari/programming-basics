using System;

namespace silmukka_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;

            Console.Write("Syötä luku jonka kertotaulu lasketaan: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} x {1} = {2} \n", n, i, n * i);
            }

            Console.ReadLine();
        }
    }
}
