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
    using System.ComponentModel.DataAnnotations;

    public partial class Comment
    {
        [Display(Name = "ID")]
        public int CommentID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Comment")]
        public string Body { get; set; }

        public int BlogPostID { get; set; }

        public virtual BlogPost BlogPost { get; set; }
    }
}
