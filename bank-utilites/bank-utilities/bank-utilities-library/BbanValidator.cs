using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bank_utilities
{
    public class Bban_validator
    {
        public static bool BBAN(string input, out string tilinum)
        {
            int len;
            bool sumOfDigits;
            tilinum = input;
            tilinum = tilinum.Replace("-", "");
            len = tilinum.Length;


            // BBAN testing.
            if (tilinum.Length > 14 || tilinum.Length == 0 || !tilinum.All(Char.IsDigit))
            {
                Exception ex = new FormatException("Tilinumero oli väärässä muodossa.");
                throw ex;
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
                        Exception ex = new FormatException("Tilinumero oli väärässä muodossa.");
                        throw ex;
                    }
                }
            }

            sumOfDigits = Mod10Check(tilinum);
            return sumOfDigits;

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