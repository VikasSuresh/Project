//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeltaX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producer
    {
        public int Producer_id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string DOB { get; set; }
        public string Bio { get; set; }
        public Nullable<int> Movieid { get; set; }
    
        public virtual Movy Movy { get; set; }
    }
}
