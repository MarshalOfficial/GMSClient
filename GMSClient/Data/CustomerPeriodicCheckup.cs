using System;
using System.ComponentModel.DataAnnotations;

namespace GMSClient.Data
{
    public class CustomerPeriodicCheckup
    {
        public long ID { get; set; }

        public long AccountID { get; set; }

        public DateTime? RegDate { get; set; }

        public double? Height { get; set; }

        [Required]
        public double? Weight { get; set; }

        public string ImgUrl { get; set; }

        public double? WaistSize { get; set; }

        public DateTime CreateDate { get; set; }

        public double? Chest { get; set; }

        public double? ABS { get; set; }

        public double? BUTT { get; set; }

        public double? RightArm { get; set; }

        public double? LeftArm { get; set; }

        public double? RightThigh { get; set; }

        public double? LeftThigh { get; set; }

        public double? RightCalves { get; set; }

        public double? LeftCalves { get; set; }

        public bool IsDeleted { get; set; }

        public string CreateDateFa { get; set; }

        [Required]
        public string RegDateFa { get; set; }

        public string FullName { get; set; }

    }
}
