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
    
    public partial class GoodsReceiptIndex
    {
        public int GoodsReceiptID { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public string Reference { get; set; }
        public string LocationCode { get; set; }
        public string CustomerName { get; set; }
        public string Description { get; set; }
        public decimal TotalQuantity { get; set; }
        public bool Approved { get; set; }
        public string Caption { get; set; }
        public string GoodsReceiptTypeCaption { get; set; }
        public string WorkshiftName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string GoodsArrivalCode { get; set; }
        public string GoodsArrivalPackingList { get; set; }
        public string GoodsArrivalCustomsDeclaration { get; set; }
        public Nullable<System.DateTime> GoodsArrivalCustomsDeclarationDate { get; set; }
        public Nullable<System.DateTime> GoodsArrivalPurchaseOrderVoucherDate { get; set; }
        public string GoodsArrivalPurchaseOrderCodes { get; set; }
        public string CustomerCode { get; set; }
    }
}
