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
    
    public partial class ORDER_FOOD
    {
        public decimal ORDER_ID { get; set; }
        public string RESTAURANT_NAME { get; set; }
        public string RESTAURANT_LOCATION { get; set; }
        public string FOOD_NAME { get; set; }
        public Nullable<decimal> NO_OF_ITEMS_PER_FOOD { get; set; }
        public string BOUGHT { get; set; }
    
        public virtual FOOD FOOD { get; set; }
        public virtual ORDER ORDER { get; set; }
    }
}
