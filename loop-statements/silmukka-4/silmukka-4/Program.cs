using System;

namespace silmukka_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int j = 0;
            int sum = 0;
            int nega = 1;

            Console.Write("Syötä luku: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                nega = -1;
            }


            for (i = 1; i <= n*nega; i++)
            {
                if (n < 0)
                {                    
                    j = j + i*nega;
                    
                }
                else 
                {
                    sum = sum + i;
                }
            }

            if (nega == -1)
            {
                Console.WriteLine("{0}", j);
            }
            else
            {
                Console.Write("{0}", sum);
            }
            Console.ReadLine();

        }
    }
}