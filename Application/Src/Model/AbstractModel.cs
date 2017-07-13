using System;

namespace Model
{
    public abstract class AbstractModel
    {
        public string FromDate(DateTime date)
        {
            return date.ToShortDateString();
        }
    }
}
