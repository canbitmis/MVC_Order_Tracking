//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sipsis.DAl.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Orderr = new HashSet<Orderr>();
        }
    
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> MarketID { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual Markett Markett { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orderr> Orderr { get; set; }
    }
}
