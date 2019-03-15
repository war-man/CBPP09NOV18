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
    
    public partial class FinishedItemPackage
    {
        public int FinishedItemPackageID { get; set; }
        public int FinishedItemID { get; set; }
        public int FinishedItemLotID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public int LocationID { get; set; }
        public int ShiftID { get; set; }
        public int WorkshiftID { get; set; }
        public int CustomerID { get; set; }
        public int FirmOrderID { get; set; }
        public int PlannedOrderID { get; set; }
        public string SemifinishedItemReferences { get; set; }
        public Nullable<int> FinishedHandoverID { get; set; }
        public Nullable<System.DateTime> FinishedHandoverDate { get; set; }
        public int CommodityID { get; set; }
        public int CommodityTypeID { get; set; }
        public int BatchID { get; set; }
        public System.DateTime BatchEntryDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityReceipted { get; set; }
        public string Remarks { get; set; }
        public bool Approved { get; set; }
        public bool HandoverApproved { get; set; }
    
        public virtual FinishedItem FinishedItem { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual Workshift Workshift { get; set; }
    }
}
