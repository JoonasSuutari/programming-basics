using System;

namespace silmukka_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, k;
            int kruunu = 0;
            int klaava = 0;
            Random rnd = new Random();

            Console.Write("Monta kertaa kolikkoa heitetään?\n");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                k = rnd.Next(0, 2);
                if (k == 0)
                {
                    kruunu++;
                }
                else
                {
                    klaava++;
                }

            }
            Console.Write("Vastaus:\n Rahaa on heitetty {0} kertaa.\n Klaavoja tuli {1} ja kruunuja {2}", n, klaava, kruunu);
            Console.ReadLine();
        }
    }
}
