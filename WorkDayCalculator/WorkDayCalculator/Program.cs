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
            WeekEnd[] weekends = new WeekEnd[3]
            {
                new WeekEnd(new DateTime(2020, 4, 6), new DateTime(2020, 4, 10)),
                new WeekEnd(new DateTime(2020, 4, 13), new DateTime(2020, 4, 16)),
                new WeekEnd(new DateTime(2020, 4, 17), new DateTime(2020, 4, 17))

            };
            DateTime result = new WorkDayCalculator().Calculate(startDate, count, weekends);

            Console.WriteLine(result);
        }
    }
}
