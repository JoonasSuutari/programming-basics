using System;

namespace silmukka_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;

            Console.Write("Syötä luku: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
            }



            Console.ReadLine();
        }
    }
}
