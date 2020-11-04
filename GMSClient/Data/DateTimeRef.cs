using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMSClient.Data
{
    public class DateTimeRef
    {
        public long DateTimeRef_ID { get; set; }
        public string DaySh { get; set; }
        public string WeekDayShName { get; set; }
        public string DateSh { get; set; }

        public string MonthShName { get; set; }

        public long ShiftPatterHeaderID { get; set; }

        public string ShiftPatterHeaderTitle { get; set; }    

    }
}
    