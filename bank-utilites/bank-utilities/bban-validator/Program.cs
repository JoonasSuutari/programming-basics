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
            string tilinum;
            int len;
            bool sumOfDigits;

            Console.WriteLine("Syötä tilinumero: ");
            tilinum = Console.ReadLine();

            // Remove '-'
            tilinum = tilinum.Replace("-", "");
            // Form machine format account number (14 digits)
            // Check account number check digit



            len = tilinum.Length;

            if (tilinum.Length > 14)
            {
                Console.WriteLine("Nyt tapahtui virhe. Yritä uudestaan. \n");
                Console.WriteLine("Syötä tilinumero: ");
                tilinum = Console.ReadLine();
            }
            else if (tilinum.Length < 14)
            {
                while (tilinum.Length < 14)
                {
                    if (tilinum[0] == '1' || tilinum[0] == '2' || tilinum[0] == '3' && tilinum[1] == '1' || tilinum[0] == '3' && tilinum[1] == '3' || tilinum[0] == '3' && tilinum[1] == '4' ||
                        tilinum[0] == '3' && tilinum[1] == '6' || tilinum[0] == '3' && tilinum[1] == '7' || tilinum[0] == '3' && tilinum[1] == '8' || tilinum[0] == '3' && tilinum[1] == '9' ||
                        tilinum[0] == '6' || tilinum[0] == '8')
                    {
                        tilinum = tilinum.Insert(6, "0");
                    }
                    else if (tilinum[0] == '4' || tilinum[0] == '5')
                    {
                        tilinum = tilinum.Insert(7, "0");
                    }
                    else
                    {
                        Console.WriteLine("Nyt tapahtui virhe. Yritä uudestaan. \n");
                        Console.WriteLine("Syötä tilinumero: ");
                        tilinum = Console.ReadLine();
                    }
                }
            }
            else
            {
                sumOfDigits = Mod10Check(tilinum);
                Console.WriteLine(sumOfDigits);
            }
        }

        public static bool Mod10Check(string tilinum)
        {
            if (string.IsNullOrEmpty(tilinum))
            {
                return false;
            }
            int sumOfDigits = tilinum.Where((e) => e >= '0' && e <= '9')
                            .Reverse()
                            .Select((e, i) => ((int)e - 48) * (i % 2 == 0 ? 1 : 2))
                            .Sum((e) => e / 10 + e % 10);

            return sumOfDigits % 10 == 0;
        }
    }
}
