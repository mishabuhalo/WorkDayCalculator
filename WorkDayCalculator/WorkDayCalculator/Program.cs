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
            DateTime startDate = new DateTime(2020, 4, 8);
            int count = 5;
            WeekEnd[] weekends = new WeekEnd[5]
            {
                new WeekEnd(new DateTime(2020, 4, 9), new DateTime(2020, 4, 10)),
                new WeekEnd(new DateTime(2020, 4, 12), new DateTime(2020, 4, 17)),
                new WeekEnd(new DateTime(2020, 4, 18), new DateTime(2020, 4, 20)),
                new WeekEnd(new DateTime(2020, 4, 21), new DateTime(2020, 4, 21)),
                new WeekEnd(new DateTime(2020, 4, 25), new DateTime(2020, 4, 26)),
            };
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, weekends);

            Console.WriteLine(result);
        }
    }
}
