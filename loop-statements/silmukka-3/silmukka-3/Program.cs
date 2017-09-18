using System;

namespace silmukka_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä luku: ");

            string userInput = Console.ReadLine().ToString();
            int.TryParse(userInput, out int luku);

            int j = 0;
            int k = 0;

            for (int i = 1; i <= luku; i++)
            {
                if (i % 2 == 0)
                {
                    j = j + i;
                }
                else
                {
                    k = k + i;
                }
            }

            Console.WriteLine("Parillisten summa: {0}", j);
            Console.WriteLine("Parittomien summa: {0}\n", k);
            Console.ReadLine();
        }
    }
}
