//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobDescription
    {
        public JobDescription()
        {
            this.MT_EMPLOYEEDETAILS = new HashSet<AllEmployeeDetails>();
            this.TR_EMPATTENDANCE = new HashSet<EmpAttendance>();
            this.MT_ATTENDANCE = new HashSet<Attendance>();
            this.TR_EMPLEAVE = new HashSet<EmployeeLeave>();
            this.MT_LEAVE = new HashSet<Leave>();
        }
    
        public int JOB_ID { get; set; }
        public string JOB_ROLE { get; set; }
    
        public virtual ICollection<AllEmployeeDetails> MT_EMPLOYEEDETAILS { get; set; }
        public virtual ICollection<EmpAttendance> TR_EMPATTENDANCE { get; set; }
        public virtual ICollection<Attendance> MT_ATTENDANCE { get; set; }
        public virtual ICollection<EmployeeLeave> TR_EMPLEAVE { get; set; }
        public virtual ICollection<Leave> MT_LEAVE { get; set; }
    }
}
