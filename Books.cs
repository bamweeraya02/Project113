//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookDemo6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }
        public string Photo { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual Categories Categories { get; set; }
    }
}
