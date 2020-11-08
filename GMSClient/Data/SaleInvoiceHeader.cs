using System;
using System.ComponentModel.DataAnnotations;

namespace GMSClient.Data
{
    public class SaleInvoiceHeader
    {
        public long ID { get; set; }

        public DateTime Inv_Date { get; set; }

        public long AccountID { get; set; }

        public long? VisitorID { get; set; }

        public short Inv_Type { get; set; }

        public double? Price { get; set; }

        public double? Reduction { get; set; }

        public string Inv_Memo { get; set; }

    }


}
