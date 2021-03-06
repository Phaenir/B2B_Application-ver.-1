//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class search_result
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public search_result()
        {
            this.roundtrip2 = new HashSet<roundtrip>();
            this.stops = new HashSet<stops>();
        }
    
        public int id { get; set; }
        public System.DateTime search_time { get; set; }
        public string url { get; set; }
        public int type { get; set; }
        public string departure { get; set; }
        public string arrival { get; set; }
        public System.DateTime dep_date { get; set; }
        public System.TimeSpan det_time { get; set; }
        public System.DateTime arr_date { get; set; }
        public System.TimeSpan arr_time { get; set; }
        public bool roundtrip { get; set; }
        public Nullable<int> roundtrip_id { get; set; }
        public int serviceClass { get; set; }
        public string validate_carrier { get; set; }
        public int validateFlight_number { get; set; }
        public string operate_carrier { get; set; }
        public Nullable<int> operateFlight_number { get; set; }
        public int travelDuration { get; set; }
        public decimal tariff { get; set; }
        public decimal taxes { get; set; }
        public Nullable<decimal> fee { get; set; }
        public Nullable<decimal> charges { get; set; }
        public decimal price { get; set; }
    
        public virtual contributors_type contributors_type { get; set; }
        public virtual roundtrip roundtrip1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<roundtrip> roundtrip2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stops> stops { get; set; }
        public virtual service_class service_class { get; set; }
    }
}
