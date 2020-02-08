using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = new DateTime(2017, 4, 21);
            int count = 5;
            WeekEnd[] weekends = new WeekEnd[2]
            {
                new WeekEnd(new DateTime(2017, 4, 23), new DateTime(2017, 4, 25)),
                new WeekEnd(new DateTime(2017, 4, 29), new DateTime(2017, 4, 29))
            };
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, weekends);
            //DateTime result = startDate.AddDays(tmpDate2.Subtract(tmpDate1).TotalDays+1);
            Console.WriteLine(result);
        }
    }
}
