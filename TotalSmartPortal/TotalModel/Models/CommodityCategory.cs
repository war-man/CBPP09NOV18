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
    
    public partial class CommodityCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CommodityCategory()
        {
            this.CommodityCategories1 = new HashSet<CommodityCategory>();
            this.Commodities = new HashSet<Commodity>();
        }
    
        public int CommodityCategoryID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int LimitedMonthWarranty { get; set; }
        public int LimitedKilometreWarranty { get; set; }
        public Nullable<int> AncestorID { get; set; }
        public int NoExpiryDate { get; set; }
        public decimal CustomsPercent { get; set; }
        public decimal ExcisePercent { get; set; }
        public decimal VATPercent { get; set; }
        public decimal ClearancePercent { get; set; }
        public string Remarks { get; set; }
        public int CommodityTypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CommodityCategory> CommodityCategories1 { get; set; }
        public virtual CommodityCategory CommodityCategory1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commodity> Commodities { get; set; }
    }
}
