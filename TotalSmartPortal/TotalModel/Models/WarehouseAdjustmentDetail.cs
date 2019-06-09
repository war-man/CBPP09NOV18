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
    
    public partial class WarehouseAdjustmentDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WarehouseAdjustmentDetail()
        {
            this.GoodsReceiptDetails = new HashSet<GoodsReceiptDetail>();
        }
    
        public int WarehouseAdjustmentDetailID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string Reference { get; set; }
        public int WarehouseAdjustmentID { get; set; }
        public int WarehouseAdjustmentTypeID { get; set; }
        public string AdjustmentJobs { get; set; }
        public Nullable<int> GoodsReceiptDetailID { get; set; }
        public Nullable<int> GoodsReceiptID { get; set; }
        public int OrganizationalUnitID { get; set; }
        public int LocationID { get; set; }
        public int WarehouseID { get; set; }
        public int WarehouseReceiptID { get; set; }
        public int CommodityID { get; set; }
        public int CommodityTypeID { get; set; }
        public int BatchID { get; set; }
        public System.DateTime BatchEntryDate { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityReceipted { get; set; }
        public string Remarks { get; set; }
        public bool Approved { get; set; }
        public int NMVNTaskID { get; set; }
        public int CustomerID { get; set; }
    
        public virtual WarehouseAdjustment WarehouseAdjustment { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Warehouse Warehouse1 { get; set; }
        public virtual Commodity Commodity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsReceiptDetail> GoodsReceiptDetails { get; set; }
        public virtual GoodsReceiptDetail GoodsReceiptDetail { get; set; }
    }
}
