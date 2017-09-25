using System;

namespace functions_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int tulos = Testaaja(i, n);

            Console.ReadLine();
        }

        public static int Testaaja(int i, int n)
        {

            Console.WriteLine("Syötä 10 lukua\n");

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0}. ", i);
                n = Convert.ToInt32(Console.ReadLine());

                if (n > 0)
                {
                    Console.Clear();
                    continue;
                }
            }


        }
    }
}
