//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace form_controls.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class member
    {
        public string memb_no { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public Nullable<int> countryid { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> startingDate { get; set; }
    
        public virtual country country { get; set; }
    }
}
