using System;
using System.Globalization;

namespace mainWindow
{
    public class DateInputValidator
    {

        #region Constructors

        public DateInputValidator()
        {
        }

        #endregion

        #region Properties



        #endregion

        #region Public Methods

        public bool ValidateDate(string possibleDateString)
        {
            DateTime date;
            string[] format = { "MM/dd/yyyy", "MM dd yyyy", "MM-dd-yyyy", "M/d/yyyy" };
            return DateTime.TryParseExact(possibleDateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
        }

        #endregion

        #region Helper Methods



        #endregion

    }
}
