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
    
    public partial class tblUserProcess
    {
        public int userProcessID { get; set; }
        public Nullable<int> processID { get; set; }
        public Nullable<int> userRolesID { get; set; }
    
        public virtual tblProcess tblProcess { get; set; }
        public virtual tblUserRoles tblUserRoles { get; set; }
    }
}
