//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Enterprise_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Student_Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_Student_Detail()
        {
            this.Contributions = new HashSet<Contribution>();
        }
    
        public string userId { get; set; }
        public int stdID { get; set; }
        public string std_fullname { get; set; }
        public string std_mail { get; set; }
        public string std_gender { get; set; }
        public Nullable<System.DateTime> std_doB { get; set; }
        public string std_phone { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contribution> Contributions { get; set; }
    }
}
