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
    
    public partial class MaterialIssueViewDetail
    {
        public int MaterialIssueDetailID { get; set; }
        public int MaterialIssueID { get; set; }
        public int CommodityID { get; set; }
        public string CommodityCode { get; set; }
        public string CommodityName { get; set; }
        public int CommodityTypeID { get; set; }
        public decimal Quantity { get; set; }
        public string Remarks { get; set; }
        public int GoodsReceiptID { get; set; }
        public int GoodsReceiptDetailID { get; set; }
        public System.DateTime GoodsReceiptEntryDate { get; set; }
        public string GoodsReceiptReference { get; set; }
        public string GoodsReceiptCode { get; set; }
        public Nullable<decimal> QuantityAvailables { get; set; }
        public int FirmOrderMaterialID { get; set; }
        public Nullable<decimal> FirmOrderRemains { get; set; }
        public int BatchID { get; set; }
        public System.DateTime BatchEntryDate { get; set; }
        public int LabID { get; set; }
        public string Barcode { get; set; }
        public string BatchCode { get; set; }
        public string SealCode { get; set; }
        public string LabCode { get; set; }
        public Nullable<System.DateTime> ProductionDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string LayerCode { get; set; }
        public int BomID { get; set; }
        public int BomDetailID { get; set; }
    }
}
