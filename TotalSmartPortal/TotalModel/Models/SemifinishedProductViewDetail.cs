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
    
    public partial class SemifinishedProductViewDetail
    {
        public int SemifinishedProductDetailID { get; set; }
        public int FirmOrderDetailID { get; set; }
        public int PlannedOrderDetailID { get; set; }
        public int CommodityID { get; set; }
        public string CommodityCode { get; set; }
        public string CommodityName { get; set; }
        public int CommodityTypeID { get; set; }
        public Nullable<decimal> QuantityRemains { get; set; }
        public decimal Quantity { get; set; }
        public string Remarks { get; set; }
        public int SemifinishedProductID { get; set; }
        public int PlannedOrderID { get; set; }
        public decimal MoldQuantity { get; set; }
        public int PiecePerPack { get; set; }
    }
}
