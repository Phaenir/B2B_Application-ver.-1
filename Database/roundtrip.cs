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
    
    public partial class roundtrip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public roundtrip()
        {
            this.search_result = new HashSet<search_result>();
        }
    
        public int Id { get; set; }
        public int search_id { get; set; }
        public string departure { get; set; }
        public string arrival { get; set; }
        public System.DateTime dep_date { get; set; }
        public System.TimeSpan dep_time { get; set; }
        public System.DateTime arr_date { get; set; }
        public System.TimeSpan arr_time { get; set; }
        public int serviceClass { get; set; }
        public string validate_carrier { get; set; }
        public string validateFlight_number { get; set; }
        public string operate_carrier { get; set; }
        public string operateFlight_number { get; set; }
        public Nullable<int> travelDuration { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<search_result> search_result { get; set; }
        public virtual search_result search_result1 { get; set; }
        public virtual service_class service_class { get; set; }
    }
}
