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
    
    public partial class tblProcess
    {
        public tblProcess()
        {
            this.tblUserProcess = new HashSet<tblUserProcess>();
            this.tblWorkFlow = new HashSet<tblWorkFlow>();
        }
    
        public int processID { get; set; }
        public string processName { get; set; }
        public Nullable<int> projectID { get; set; }
        public Nullable<int> processTypeID { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> finishDate { get; set; }
        public Nullable<int> completeRate { get; set; }
        public string detail { get; set; }
        public Nullable<int> priority { get; set; }
        public Nullable<int> createUserID { get; set; }
        public string description { get; set; }
        public string note { get; set; }
        public Nullable<int> userID { get; set; }
        public Nullable<int> duration { get; set; }
    
        public virtual tblProcessType tblProcessType { get; set; }
        public virtual tblUsers tblUsers { get; set; }
        public virtual tblUsers tblUsers1 { get; set; }
        public virtual ICollection<tblUserProcess> tblUserProcess { get; set; }
        public virtual ICollection<tblWorkFlow> tblWorkFlow { get; set; }
    }
}