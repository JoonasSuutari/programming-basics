using System;
using bank_utilities;
using bank_utilities_library;
namespace iban_validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string inputIban;
            string tilinum;
            string askService;
            bool error = true;


            do
            {
                Console.WriteLine("Haluatko 1) muuntaa tilinumeron IBAN muotoon vai 2) tarkistaa IBAN tilinumeron?");
                askService = Console.ReadLine();

                if (askService == "1")
                {
                    try
                    {
                        Console.WriteLine("Syötä tilinumero: ");
                        input = Console.ReadLine();
                        bool isValid = Bban_validator.BBAN(input, out tilinum);
                        if (isValid == true)
                        {
                            error = false;
                            string iban = IbanConverter.CreateIban(tilinum);
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine("{0} \nTilinumero on validi.", iban);
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
                }
                else if (askService == "2")
                {
                    try
                    {
                        Console.WriteLine("Syötä IBAN muotoinen tilinumero: ");
                        inputIban = Console.ReadLine();
                        bool ibanIsValid = IbanValidator.ValidateIBAN(inputIban);
                        if (ibanIsValid == true)
                        {
                            error = false;
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine("{0} \nTilinumero on validi.", inputIban);
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
                }
            } while (error);
            Console.ReadLine();
        }
    }
}
