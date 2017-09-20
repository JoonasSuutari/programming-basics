using System;

namespace silmukka_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int j;

            for (int i = 1; i <= 13; i++)
            {
                Console.Write("{0,2}. ", i);
                j = rnd.Next(1, 11);

                if (j <= 4)
                {
                    Console.WriteLine("1");
                }
                else if (j >= 5 && j <= 6)
                {
                    Console.WriteLine("X");
                }
                else
                {
                    Console.WriteLine("2");
                }
            }
            Console.ReadLine();
        }
    }
}
