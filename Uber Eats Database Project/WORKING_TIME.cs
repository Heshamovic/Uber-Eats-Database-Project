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
    
    public partial class WORKING_TIME
    {
        public string DAY { get; set; }
        public string RESTAURANT_NAME { get; set; }
        public string RESTAURANT_LOCATION { get; set; }
        public Nullable<decimal> START_TIME { get; set; }
        public Nullable<decimal> END_TIME { get; set; }
    
        public virtual RESTAURANT RESTAURANT { get; set; }
    }
}
