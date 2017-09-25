using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bank_utilities
{
    class Bban_validator
    {
        static void BBAN()
        {
            string tilin;
            int len;
            bool sumOfDigits;

            Console.WriteLine("Syötä tilinumero: ");
            tilin = Console.ReadLine();
            sumOfDigits = Mod10Check(tilin);
            len = tilin.Length;

            if (len < 14)
            {
                Console.WriteLine("Nyt tapahtui virhe. Yritä uudestaan. \n");
                Console.WriteLine("Syötä tilinumero: ");
                tilin = Console.ReadLine();
            }
            else if (len > 14)
            {
                while (len > 14)
                {
                    if (tilin[0] == '1' || tilin[0] == '2' || tilin[0] == '3' && tilin[1] == '1' || tilin[0] == '3' && tilin[1] == '3' || tilin[0] == '3' && tilin[1] == '4' ||
                        tilin[0] == '3' && tilin[1] == '6' || tilin[0] == '3' && tilin[1] == '7' || tilin[0] == '3' && tilin[1] == '8' || tilin[0] == '3' && tilin[1] == '9' ||
                        tilin[0] == '6' || tilin[0] == '8')
                    {
                        tilin = tilin + "0";
                    }
                    else if (tilin[0] == '4' || tilin[0] == '5')
                    {
                        tilin = tilin + "0";
                    }
                    else
                    {
                        Console.WriteLine("Nyt tapahtui virhe. Yritä uudestaan. \n");
                        Console.WriteLine("Syötä tilinumero: ");
                        tilin = Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine(sumOfDigits);
            }
        }

        public static bool Mod10Check(string tilin)
        {
            if (string.IsNullOrEmpty(tilin))
            {
                return false;
            }
            int sumOfDigits = tilin.Where((e) => e >= '0' && e <= '9')
                            .Reverse()
                            .Select((e, i) => ((int)e - 48) * (i % 2 == 0 ? 1 : 2))
                            .Sum((e) => e / 10 + e % 10);

            return sumOfDigits % 10 == 0;
        }
    }
}
