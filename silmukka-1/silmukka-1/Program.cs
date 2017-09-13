using System;

namespace silmukka_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f=1, num;

            Console.Write("Syötä numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
            {
                Console.Write("Tulos: {0}", num);
            }

            else if (num < 0)
            {
                Console.Write("Määrittelemätön");
            }

            else
            {
                for (i = 1; i <= num; i++)
                    f = f * i;

                Console.Write("Tulos: {0}", f);
            }

            Console.ReadLine();
        }
    }
}
