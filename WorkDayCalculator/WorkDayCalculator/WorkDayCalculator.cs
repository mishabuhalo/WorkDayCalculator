using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDayCalculator
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            DateTime result = new DateTime();
            if (weekEnds == null)
                return startDate.AddDays(dayCount - 1);
            result = startDate;

            for(int i=0; i < weekEnds.Length; i++)
            {
                if (result > weekEnds[i].endDate)
                    continue;

                if(result > weekEnds[i].startDate && result <= weekEnds[i].endDate)
                {
                    result = result.AddDays(weekEnds[i].endDate.Subtract(result).TotalDays+1);
                    continue;
                }

                if (result.AddDays(dayCount-1) < weekEnds[i].startDate)
                    return result.AddDays(dayCount-1);
                else
                   result = result.AddDays(weekEnds[i].endDate.Subtract(weekEnds[i].startDate).TotalDays+1);
            }

            return result.AddDays(dayCount-1);
        }
    }
}
