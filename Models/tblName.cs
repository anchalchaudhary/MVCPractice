//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCTutorial.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblName
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblName()
        {
            this.tblCities = new HashSet<tblCity>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> BranchID { get; set; }
    
        public virtual tblBranch tblBranch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCity> tblCities { get; set; }
    }
}
