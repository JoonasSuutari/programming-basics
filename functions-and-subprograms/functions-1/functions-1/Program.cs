using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Kuinka monta tähteä haluat? \n");
            n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                string stars = StarsLoop(n);
                Console.WriteLine(stars);
            }
            else
            {
                Console.WriteLine("{0} ei ole sallittu.", n);
            }
            Console.ReadLine();
        }

        public static string StarsLoop(int n)
        {
            string stars = "\n";
            for (int i = 1; i <= n; i++)
            {
                stars = stars + "*";
            }
            return stars;
        }
    
}