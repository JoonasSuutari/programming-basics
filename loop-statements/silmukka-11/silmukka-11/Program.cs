using System;

namespace silmukka_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int kutonen = 0;

            for (int i = 1; i <= 1000; i++)
            {
                int noppa = rnd.Next(1, 7);
                Console.WriteLine("{0,2}. {1,2}",i , noppa);
                if (noppa == 6)
                {
                    kutonen++;
                }
            }
            Console.WriteLine("Kuutonen arvottiin {0} kertaa.", kutonen);
            Console.ReadLine();
        }
    }
}
