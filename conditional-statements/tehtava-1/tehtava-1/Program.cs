using System;

namespace tehtava_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Kirjoita yksi luku : ");
            Console.Write("\n");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)

                Console.WriteLine("Vastaus Numero {0} on positiivinen. \n", num);
            else if (num == 0)

                Console.WriteLine("Vastaus Numero {0} on nolla. \n", num);

            else
                Console.WriteLine("Vastaus Numero {0} on negatiivinen \n", num);

            Console.ReadLine();
        }
    }
}
