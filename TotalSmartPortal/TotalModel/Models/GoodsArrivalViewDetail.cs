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
    
    public partial class GoodsArrivalViewDetail
    {
        public int GoodsArrivalDetailID { get; set; }
        public int GoodsArrivalID { get; set; }
        public Nullable<int> PurchaseOrderID { get; set; }
        public Nullable<int> PurchaseOrderDetailID { get; set; }
        public string PurchaseOrderReference { get; set; }
        public string PurchaseOrderCode { get; set; }
        public Nullable<System.DateTime> PurchaseOrderEntryDate { get; set; }
        public int CommodityID { get; set; }
        public string CommodityCode { get; set; }
        public string CommodityName { get; set; }
        public int CommodityTypeID { get; set; }
        public Nullable<decimal> QuantityRemains { get; set; }
        public decimal Quantity { get; set; }
        public string Remarks { get; set; }
        public string SealCode { get; set; }
        public string BatchCode { get; set; }
        public string LabCode { get; set; }
        public decimal UnitWeight { get; set; }
        public decimal Packages { get; set; }
        public Nullable<int> Shelflife { get; set; }
        public Nullable<System.DateTime> ProductionDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public int BatchID { get; set; }
        public System.DateTime BatchEntryDate { get; set; }
        public decimal TareWeight { get; set; }
    }
}
