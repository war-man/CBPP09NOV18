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
    
    public partial class SemifinishedProductDetail
    {
        public int SemifinishedProductDetailID { get; set; }
        public int SemifinishedProductID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public int LocationID { get; set; }
        public int CustomerID { get; set; }
        public int MaterialIssueID { get; set; }
        public int MaterialIssueDetailID { get; set; }
        public int FirmOrderID { get; set; }
        public int FirmOrderDetailID { get; set; }
        public int PlannedOrderID { get; set; }
        public int PlannedOrderDetailID { get; set; }
        public int GoodsReceiptID { get; set; }
        public int GoodsReceiptDetailID { get; set; }
        public int ShiftID { get; set; }
        public int WorkshiftID { get; set; }
        public int ProductionLineID { get; set; }
        public int CrucialWorkerID { get; set; }
        public Nullable<int> SemifinishedHandoverID { get; set; }
        public int CommodityID { get; set; }
        public int CommodityTypeID { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityFinished { get; set; }
        public string Remarks { get; set; }
        public bool Approved { get; set; }
        public bool HandoverApproved { get; set; }
        public int PiecePerPack { get; set; }
        public int MoldQuantity { get; set; }
    
        public virtual Commodity Commodity { get; set; }
        public virtual FirmOrder FirmOrder { get; set; }
        public virtual MaterialIssueDetail MaterialIssueDetail { get; set; }
        public virtual MaterialIssue MaterialIssue { get; set; }
        public virtual PlannedOrderDetail PlannedOrderDetail { get; set; }
        public virtual SemifinishedProduct SemifinishedProduct { get; set; }
        public virtual FirmOrderDetail FirmOrderDetail { get; set; }
    }
}
