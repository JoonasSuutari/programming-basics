using System;
using bank_utilities;

namespace bban_validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string tilinum;
            bool error = true;

            do
            {
                Console.WriteLine("Syötä tilinumero: ");
                input = Console.ReadLine();

                try
                {
                    bool isValid = Bban_validator.BBAN(input, out tilinum);
                    if (isValid == true)
                    {
                        error = false;
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("{0} \nTilinumero on validi.", tilinum);
                    }
                    else
                    {
                        Console.WriteLine("Tilinumero ei ole validi.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (error);

            Console.ReadLine();
        }
    }
}
