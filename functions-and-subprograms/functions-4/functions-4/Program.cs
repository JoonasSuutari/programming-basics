
using System;

namespace functions_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int max;
            max = Tester(i);

            Console.WriteLine("Suurin luku oli {0}.", max);
            Console.ReadLine();
        }

        public static int Tester(int i)
        {
            int n, maxPrint = 0;

            Console.WriteLine("Syötä kymmenen lukua.");

            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0}. ", i);

                string userInput = Console.ReadLine();

                while ((!int.TryParse(userInput, out n)) || (n < 0))
                {
                    Console.WriteLine("Syötä positiivinen luku.");
                    Console.Write("{0}. ", i);

                    userInput = Console.ReadLine();
                }

                if (maxPrint < n)
                {
                    maxPrint = n;
                }
            }
            return maxPrint;
        }
    }
}