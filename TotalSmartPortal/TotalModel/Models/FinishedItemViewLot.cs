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
    
    public partial class FinishedItemViewLot
    {
        public int FinishedItemLotID { get; set; }
        public int FinishedItemID { get; set; }
        public int CommodityID { get; set; }
        public string CommodityCode { get; set; }
        public string CommodityName { get; set; }
        public int CommodityTypeID { get; set; }
        public int BatchID { get; set; }
        public System.DateTime BatchEntryDate { get; set; }
        public int PiecePerPack { get; set; }
        public decimal PackageUnitWeights { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityFailure { get; set; }
        public decimal QuantityExcess { get; set; }
        public decimal QuantityShortage { get; set; }
        public decimal Swarfs { get; set; }
        public decimal Packages { get; set; }
        public decimal OddPackages { get; set; }
        public string Remarks { get; set; }
    }
}
