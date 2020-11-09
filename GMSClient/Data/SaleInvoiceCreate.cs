using System;
using System.ComponentModel.DataAnnotations;

namespace GMSClient.Data
{
    public class SaleInvoiceCreate
    {

        public string Inv_Date { get; set; }

        public long AccountID { get; set; }

        public long VisitorID { get; set; }

        public long ProductID { get; set; }
        public double? Reduction { get; set; }

        public string Inv_Memo { get; set; }
    }


}