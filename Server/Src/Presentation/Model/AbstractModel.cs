using System;

namespace Presentation
{
    public abstract class AbstractModel
    {
        public string FromDate(DateTime date)
        {
            return date.ToShortDateString();
        }
    }
}
