using System;

namespace GMSClient.Data
{
    public class ShiftPatternHeader
    {
        public long ID { get; set; }
        
        public string Title { get; set; }
        
        public bool IsDeleted { get; set; }
        
        public DateTime CreateDate { get; set; }

        public string CreateDateFa { get; set; }
    }
}
