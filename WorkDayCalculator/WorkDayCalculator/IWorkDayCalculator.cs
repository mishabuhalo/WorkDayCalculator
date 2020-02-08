using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDayCalculator
{
    public interface IWorkDayCalculator
    {
        DateTime Calculate(DateTime StartDate, int DayCount, WeekEnd[] weekEnds);
    }
}
