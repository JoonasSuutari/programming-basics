using System;

namespace tehtava_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Kirjoita yksi luku : ");
            Console.Write("\n");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0 && num > 0)
                Console.WriteLine("Vastaus Numero {0} on parillinen ja positiivinen. \n", num);

            else if (num % 2 == 0 && num < 0)
                Console.WriteLine("Vastaus Numero {0} on parillinen ja negatiivinen. \n", num);

            else if (num % 2 != 0 && num > 0)
                Console.WriteLine("Vastaus Numero {0} on pariton ja positiivinen. \n", num);

            else if (num == 0)
                Console.WriteLine("Vastaus Numero {0} on nolla ja parillinen. \n", num);

            else
                Console.WriteLine("Vastaus Numero {0} on pariton ja negatiivinen. \n", num);

            Console.ReadLine();
        }
    }
}
