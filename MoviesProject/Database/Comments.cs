//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoviesProject.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public Nullable<int> MovieId { get; set; }
    
        public virtual Movies Movies { get; set; }
        public virtual User User { get; set; }
    }
}
