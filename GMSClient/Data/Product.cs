﻿using System;
namespace GMSClient.Data
{
    public class Product
    {
        public long ProductID { get; set; }

        public DateTime CreateDate { get; set; }

        public long CodingID { get; set; }

        public string ProductCode { get; set; }

        public string ProductName { get; set; }

        public double? BuyPrice { get; set; }

        public double? SalePrice { get; set; }

        public double? SalePrice2 { get; set; }

        public string ProductBarCode { get; set; }

        public int? SessionCount { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public string CreateDateFa { get; set; }

        public string StartDateFa { get; set; }

        public string EndDateFa { get; set; }

        public string IsActiveFa { get { return IsActive ? "فعال" : "غیرفعال"; } }
        
        public string SalePriceFa { get { return SalePrice?.ToString("N0"); } }
    }
}
