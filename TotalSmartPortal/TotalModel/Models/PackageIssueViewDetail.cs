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
    
    public partial class PackageIssueViewDetail
    {
        public int PackageIssueDetailID { get; set; }
        public int PackageIssueID { get; set; }
        public int BlendingInstructionDetailID { get; set; }
        public int CommodityID { get; set; }
        public string CommodityCode { get; set; }
        public string CommodityName { get; set; }
        public int CommodityTypeID { get; set; }
        public int GoodsReceiptID { get; set; }
        public int GoodsReceiptDetailID { get; set; }
        public string GoodsReceiptReference { get; set; }
        public string GoodsReceiptCode { get; set; }
        public System.DateTime GoodsReceiptEntryDate { get; set; }
        public int BatchID { get; set; }
        public System.DateTime BatchEntryDate { get; set; }
        public Nullable<decimal> QuantityAvailables { get; set; }
        public decimal Quantity { get; set; }
        public string Remarks { get; set; }
        public Nullable<decimal> QuantityRemains { get; set; }
        public int BinLocationID { get; set; }
        public string BinLocationCode { get; set; }
        public string Barcode { get; set; }
        public string BatchCode { get; set; }
        public string SealCode { get; set; }
        public string LabCode { get; set; }
    }
}
