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
    
    public partial class User_Marketing_Coordinator_Detail
    {
        public string userId { get; set; }
        public int mkcID { get; set; }
        public string mkc_fullname { get; set; }
        public string mkc_mail { get; set; }
        public string mkc_gender { get; set; }
        public Nullable<System.DateTime> mkc_doB { get; set; }
        public string mkc_phone { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
