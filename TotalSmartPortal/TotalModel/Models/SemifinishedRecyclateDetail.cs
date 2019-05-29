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
    
    public partial class SemifinishedRecyclateDetail
    {
        public int SemifinishedRecyclateDetailID { get; set; }
        public int SemifinishedRecyclateID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public int LocationID { get; set; }
        public int ShiftID { get; set; }
        public int WorkshiftID { get; set; }
        public int WarehouseID { get; set; }
        public int CrucialWorkerID { get; set; }
        public int SemifinishedProductID { get; set; }
        public int CommodityID { get; set; }
        public int CommodityTypeID { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityReceipted { get; set; }
        public string Remarks { get; set; }
        public bool Approved { get; set; }
    
        public virtual Commodity Commodity { get; set; }
        public virtual SemifinishedProduct SemifinishedProduct { get; set; }
        public virtual SemifinishedRecyclate SemifinishedRecyclate { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Workshift Workshift { get; set; }
    }
}