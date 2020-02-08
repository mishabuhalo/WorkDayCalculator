using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WorkDayCalculator;
namespace WorkDayCalculatorTest
{
    [TestClass]
    public class CalculateTests
    {
        [TestMethod]
        public void TestNoWeekEnd()
        {
            DateTime startDate = new DateTime(2020, 4, 8);
            int count = 5;

            DateTime result = new WorkDayCalculator.WorkDayCalculator().Calculate(startDate, count, null);

            Assert.AreEqual(startDate.AddDays(count - 1), result);
        }

        [TestMethod]
        public void WeekendAfterPeriod()
        {
            DateTime startDate = new DateTime(2020, 4, 8);
            int count = 5;
            WeekEnd[] weekends = new WeekEnd[1]
            {
                new WeekEnd(new DateTime(2020, 4, 13), new DateTime(2020, 4, 14))
            };
            DateTime result = new WorkDayCalculator.WorkDayCalculator().Calculate(startDate, count, weekends);

            Assert.IsTrue(result.Equals(new DateTime(2020, 4, 12)));
        }

        [TestMethod]
        public void NormalPath()
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
            DateTime result = new WorkDayCalculator.WorkDayCalculator().Calculate(startDate, count, weekends);

            Assert.IsTrue(result.Equals(new DateTime(2020, 4,24)));
        }

        [TestMethod]
        public void WeekendAfterEnd()
        {
            DateTime startDate = new DateTime(2020, 4, 8);
            int count = 5;
            WeekEnd[] weekends = new WeekEnd[2]
            {
                new WeekEnd(new DateTime(2020, 4, 10), new DateTime(2020, 4, 12)),
                new WeekEnd(new DateTime(2020, 4, 16), new DateTime(2020, 4, 16))
            };
            DateTime result = new WorkDayCalculator.WorkDayCalculator().Calculate(startDate, count, weekends);

            Assert.IsTrue(result.Equals(new DateTime(2020, 4, 15)));
        }


    }
}
