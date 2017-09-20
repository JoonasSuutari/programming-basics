using System;

namespace functions_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int n;
            int tulos = Testaaja(i);

            Console.ReadLine();
        }

        public static int Testaaja(int i, int n, int tulos)
        {
            bool isValidInput = false;
            int[] arr = new int[10];

            Console.WriteLine("Syötä 10 lukua\n");

            while (i < 10)
            {
                Console.WriteLine("{0}. ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

                if (!isValidInput)
                {
                    Console.Clear();
                    continue;
                }
            }

            tulos = arr[i].Max;


        }
    }
}
