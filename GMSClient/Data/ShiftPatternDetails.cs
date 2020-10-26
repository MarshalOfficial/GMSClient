using System;

namespace GMSClient.Data
{
    public class ShiftPatternDetails
    {
        public long ID { get; set; }

        public long ShiftPatternHeaderID { get; set; }

        public TimeSpan FromTime { get; set; }

        public TimeSpan ToTime { get; set; }

        public bool Gender { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreateDateFa { get; set; }
    }
}
