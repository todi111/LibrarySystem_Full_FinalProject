//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibrarySystemPro.DatabaseEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class RentedBook
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public Nullable<System.DateTime> DateRented { get; set; }
        public Nullable<System.DateTime> DateToReturn { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
