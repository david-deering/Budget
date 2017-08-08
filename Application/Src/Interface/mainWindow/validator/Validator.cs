using System;
using System.Globalization;

namespace Budget
{
    public static class Validator
    {

        #region Public Methods

        public static bool ValidateDate(string possibleDateString)
        {
            DateTime date;
            string[] format = { "MM/dd/yyyy", "MM dd yyyy", "MM-dd-yyyy", "M/d/yyyy" };
            return DateTime.TryParseExact(possibleDateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
        }

        public static bool ValidateDecimal(string possibleDecimalString)
        {
            decimal number;

            return decimal.TryParse(possibleDecimalString, out number);
        }

        public static bool ValidateString(string possibleNonEmptyString)
        {
            return possibleNonEmptyString.Length != 0;
        }

        #endregion

    }
}
