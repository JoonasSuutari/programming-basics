using System;

namespace functions_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 10;

            int tulos = Tarkistaja(min, max);

            Console.WriteLine("Luku {0} on kelvollinen", tulos);

            Console.ReadLine();
        }

        public static int Tarkistaja(int min, int max)
        {
            bool isAcceptableNumber = false;
            bool isValidInput = false;
            int n;

            do
            {
                Console.WriteLine("Syötä luku väliltä {0}-{1}: ", min, max);
                isValidInput = int.TryParse(Console.ReadLine(), out n);

                if (!isValidInput)
                {
                    Console.Clear();
                    continue;
                }

                if (n < min || n > max)
                {
                    Console.Clear();
                }
                else
                {
                    isAcceptableNumber = true;
                }
            } while (!isAcceptableNumber);
            return n;
        }
    }
}
