//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uber_Eats_Database_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDER()
        {
            this.ORDER_FOOD = new HashSet<ORDER_FOOD>();
        }
    
        public int ORDER_ID { get; set; }
        public decimal TIP { get; set; }
        public System.DateTime ORDER_DATE { get; set; }
        public string PAYMENT_TYPE { get; set; }
        public string STATUS { get; set; }
        public string CUSTOMER_USERNAME { get; set; }
        public decimal FOOD_PRICE { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_FOOD> ORDER_FOOD { get; set; }
        public virtual TRIP TRIP { get; set; }
    }
}
