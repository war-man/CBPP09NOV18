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
    
    public partial class GoodsReceiptDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoodsReceiptDetail()
        {
            this.MaterialIssueDetails = new HashSet<MaterialIssueDetail>();
            this.PackageIssueDetails = new HashSet<PackageIssueDetail>();
            this.SemifinishedProducts = new HashSet<SemifinishedProduct>();
            this.WarehouseAdjustmentDetails = new HashSet<WarehouseAdjustmentDetail>();
            this.WarehouseTransferDetails = new HashSet<WarehouseTransferDetail>();
        }
    
        public int GoodsReceiptDetailID { get; set; }
        public int GoodsReceiptID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string Reference { get; set; }
        public string Code { get; set; }
        public int NMVNTaskID { get; set; }
        public int LocationID { get; set; }
        public Nullable<int> LocationIssueID { get; set; }
        public int GoodsReceiptTypeID { get; set; }
        public Nullable<int> PurchaseRequisitionID { get; set; }
        public Nullable<int> PurchaseRequisitionDetailID { get; set; }
        public Nullable<int> GoodsArrivalID { get; set; }
        public Nullable<int> GoodsArrivalDetailID { get; set; }
        public Nullable<int> GoodsArrivalPackageID { get; set; }
        public Nullable<int> FinishedProductID { get; set; }
        public Nullable<int> FinishedProductPackageID { get; set; }
        public Nullable<int> MaterialIssueID { get; set; }
        public Nullable<int> MaterialIssueDetailID { get; set; }
        public Nullable<int> WarehouseTransferID { get; set; }
        public Nullable<int> WarehouseTransferDetailID { get; set; }
        public Nullable<int> WarehouseAdjustmentID { get; set; }
        public Nullable<int> WarehouseAdjustmentDetailID { get; set; }
        public Nullable<int> WarehouseAdjustmentTypeID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public int BatchID { get; set; }
        public System.DateTime BatchEntryDate { get; set; }
        public int BinLocationID { get; set; }
        public int CommodityID { get; set; }
        public int CommodityTypeID { get; set; }
        public int WarehouseID { get; set; }
        public Nullable<int> WarehouseIssueID { get; set; }
        public string SealCode { get; set; }
        public string BatchCode { get; set; }
        public string LabCode { get; set; }
        public string Barcode { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityIssued { get; set; }
        public string Remarks { get; set; }
        public bool Approved { get; set; }
        public int LabID { get; set; }
        public Nullable<System.DateTime> ProductionDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public int ShiftID { get; set; }
        public int WorkshiftID { get; set; }
    
        public virtual BinLocation BinLocation { get; set; }
        public virtual MaterialIssueDetail MaterialIssueDetail { get; set; }
        public virtual PurchaseRequisitionDetail PurchaseRequisitionDetail { get; set; }
        public virtual WarehouseAdjustmentDetail WarehouseAdjustmentDetail { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialIssueDetail> MaterialIssueDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PackageIssueDetail> PackageIssueDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SemifinishedProduct> SemifinishedProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarehouseAdjustmentDetail> WarehouseAdjustmentDetails { get; set; }
        public virtual GoodsArrivalPackage GoodsArrivalPackage { get; set; }
        public virtual FinishedProductPackage FinishedProductPackage { get; set; }
        public virtual WarehouseTransferDetail WarehouseTransferDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarehouseTransferDetail> WarehouseTransferDetails { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual Workshift Workshift { get; set; }
        public virtual GoodsReceipt GoodsReceipt { get; set; }
        public virtual Lab Lab { get; set; }
        public virtual Commodity Commodity { get; set; }
    }
}
