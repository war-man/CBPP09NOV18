//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TotalModel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoodsIssuePackage
    {
        public int GoodsIssuePackageID { get; set; }
        public int GoodsIssueID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public int LocationID { get; set; }
        public int DeliveryAdviceID { get; set; }
        public int DeliveryAdviceDetailID { get; set; }
        public int GoodsReceiptID { get; set; }
        public int GoodsReceiptDetailID { get; set; }
        public int CommodityID { get; set; }
        public int CommodityTypeID { get; set; }
        public int BatchID { get; set; }
        public System.DateTime BatchEntryDate { get; set; }
        public int WarehouseID { get; set; }
        public int BinLocationID { get; set; }
        public string SealCode { get; set; }
        public string BatchCode { get; set; }
        public string LabCode { get; set; }
        public string Barcode { get; set; }
        public decimal Quantity { get; set; }
        public string Remarks { get; set; }
        public bool Approved { get; set; }
    
        public virtual Commodity Commodity { get; set; }
        public virtual DeliveryAdviceDetail DeliveryAdviceDetail { get; set; }
        public virtual DeliveryAdvice DeliveryAdvice { get; set; }
        public virtual GoodsIssue GoodsIssue { get; set; }
        public virtual GoodsReceiptDetail GoodsReceiptDetail { get; set; }
        public virtual GoodsReceipt GoodsReceipt { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
