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
    
    public partial class SemifinishedRecyclateViewDetail
    {
        public int SemifinishedRecyclateDetailID { get; set; }
        public int SemifinishedRecyclateID { get; set; }
        public int SemifinishedProductID { get; set; }
        public string ShiftCode { get; set; }
        public string ProductionLineCode { get; set; }
        public string FirmOrderCode { get; set; }
        public string Specification { get; set; }
        public int CommodityID { get; set; }
        public string CommodityCode { get; set; }
        public int CommodityTypeID { get; set; }
        public decimal RejectWeights { get; set; }
        public decimal FailureWeights { get; set; }
        public Nullable<decimal> QuantityRemains { get; set; }
        public decimal Quantity { get; set; }
        public Nullable<int> RecycleCommodityID { get; set; }
        public string RecycleCommodityCode { get; set; }
        public System.DateTime SemifinishedProductEntryDate { get; set; }
        public string SemifinishedProductReference { get; set; }
        public string RecycleCommodityName { get; set; }
    }
}
