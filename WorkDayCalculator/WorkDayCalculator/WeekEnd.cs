﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkDayCalculator
{
    class WeekEnd
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public WeekEnd(DateTime StartDate, DateTime EndDate)
        {
            this.startDate = startDate;
            this.endDate = EndDate;
        }
    }
}