//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insurance
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entry
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<int> CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public Nullable<bool> DUI { get; set; }
        public Nullable<int> Tickets { get; set; }
        public Nullable<bool> Coverage { get; set; }
        public Nullable<decimal> Quote { get; set; }
    }
}
