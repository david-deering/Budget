using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IPayDayService
{
       
    void AddPayDay(IPayDay sprint);

    void DeletePayDay(int recordId);

    IPayDay GetPayDay(int recordId);

    IPayDay[] GetPayDays();

    void UpdatePayDay(IPayDay sprint);
    }
}
