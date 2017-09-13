using System;

namespace tehtava_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Kirjoita yksi luku : ");
            Console.Write("\n");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)

                Console.WriteLine("Vastaus Numero {0} on parillinen. \n", num);

            else
                Console.WriteLine("Vastaus Numero {0} on pariton \n", num);

            Console.ReadLine();
        }
    }
}
