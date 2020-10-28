using System;
using System.ComponentModel.DataAnnotations;

namespace GMSClient.Data
{
    public class ShiftPatternDetails
    {
        public long ID { get; set; }

        public long ShiftPatternHeaderID { get; set; }

        public TimeSpan FromTime { get; set; }

        public TimeSpan ToTime { get; set; }

        [Required]
        public DateTime? FromTimeF { get; set; }

        [Required]
        public DateTime? ToTimeF { get; set; }


        public bool Gender { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreateDateFa { get; set; }

        public string GenderFa { get { return Gender ? "مرد" : "زن"; } }

        public string HeaderTitle { get; set; } 
    }
}
