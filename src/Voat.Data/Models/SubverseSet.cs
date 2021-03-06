//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Voat.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubverseSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubverseSet()
        {
            this.SubverseSetLists = new HashSet<SubverseSetList>();
            this.SubverseSetSubscriptions = new HashSet<SubverseSetSubscription>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public int SubscriberCount { get; set; }
        public System.DateTime CreationDate { get; set; }
        public bool IsPublic { get; set; }
        public string Title { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubverseSetList> SubverseSetLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubverseSetSubscription> SubverseSetSubscriptions { get; set; }
    }
}
