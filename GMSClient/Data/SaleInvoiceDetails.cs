using System;
using System.ComponentModel.DataAnnotations;

namespace GMSClient.Data
{
    public class SaleInvoiceDetails
    {
        public long ID { get; set; }

        public long Inv_HeaderID { get; set; }

        public string InvoiceNo { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public short? Reduction_Percent { get; set; }

        public double? Reduction_Price { get; set; }

        public string inv_memo { get; set; }

        public int SessionQty { get; set; }

        public int? SessionReserved { get; set; }

        public int? SessionUsed { get; set; }

    }




}