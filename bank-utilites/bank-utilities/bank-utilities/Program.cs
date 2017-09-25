using System;

namespace bank_utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            Bban_validator bban = new Bban_validator();
            Console.WriteLine(bban);

            Console.ReadLine();
        }
    }
}
