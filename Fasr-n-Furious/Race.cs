//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fasr_n_Furious
{
    using System;
    using System.Collections.Generic;
    
    public partial class Race
    {
        public int race_id { get; set; }
        public System.TimeSpan duration { get; set; }
        public int points { get; set; }
        public int user_id { get; set; }
    
        public virtual User User { get; set; }
    }
}
