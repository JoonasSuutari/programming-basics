using System;

namespace functions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            Console.WriteLine("Syötä ensimmäinen luku: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Syötä toinen luku: ");
            m = Convert.ToInt32(Console.ReadLine());

            int min = Minimi(n, m);
            Console.WriteLine("\n{0} on pienempi luku.", min);

            Console.ReadLine();
        }

        public static int Minimi(int n, int m)
        {
            int min = Math.Min(n, m);

            return min;
        }
    }
}
