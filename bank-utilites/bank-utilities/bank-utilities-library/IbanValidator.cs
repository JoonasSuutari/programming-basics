using System;
using System.Collections.Generic;
using System.Text;
using bank_utilities;
using bank_utilities_library;

namespace bank_utilities_library
{
    public class IbanValidator
    {
        public static bool ValidateIBAN(string inputIban)
        {
            bool ibanIsValid = false;

            string iso = inputIban.Substring(0, 4);
            inputIban = inputIban.Replace(iso, "");
            inputIban = inputIban.Replace(" ", "");
            inputIban = inputIban.Insert(14, iso);
            inputIban = inputIban.Replace("FI", "1518");
            decimal ibanValidate = Decimal.Parse(inputIban);

            if (ibanValidate % 97 == 1)
            {
                ibanIsValid = true;
            }
            else
            {
                Exception ex = new FormatException("Tilinumero oli väärässä muodossa.");
                throw ex;
            }


            return ibanIsValid;
        }
        
    }
}
