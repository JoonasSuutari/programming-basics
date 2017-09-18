using System;

namespace silmukka_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double j = 0;

            for (int i = 1; i <= 10; i++)
                {
                    j = Math.Round(Math.Sqrt(i), 2);
                    Console.WriteLine("Luvun {0} neliöjuuri on {1}\n", i, j);
                }
            Console.ReadLine();
        }
    }
}
