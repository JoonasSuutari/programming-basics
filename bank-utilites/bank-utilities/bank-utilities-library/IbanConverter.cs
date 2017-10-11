using System;
using System.Collections.Generic;
using System.Text;
using bank_utilities;

namespace bank_utilities_library
{
   public class IbanConverter
    {
        public static string CreateIban(string input)
        {
            string ibanConverted;
            string bban;
            Bban_validator.BBAN(input, out bban);

            string iban = bban.Insert(14, "151800");

            decimal checkNumber = Decimal.Parse(iban);

            int ibanCheck = 98 - (int)(checkNumber % 97);

            ibanConverted = bban.Insert(0, "FI");

            ibanConverted = ibanConverted.Insert(2, ibanCheck.ToString("D2"));

            return ibanConverted;
        }
    }
}
