//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProcessType
    {
        public tblProcessType()
        {
            this.tblProcess = new HashSet<tblProcess>();
        }
    
        public int processTypeID { get; set; }
        public string processTypeName { get; set; }
    
        public virtual ICollection<tblProcess> tblProcess { get; set; }
    }
}
