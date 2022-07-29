namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LeaveOpening
    {
        public int Id { get; set; }

        public long EmpId { get; set; }

        public int LeaveSettingId { get; set; }

        public int TotalCL { get; set; }

        public int TotalLeaveCL { get; set; }

        public int TotalSL { get; set; }

        public int TotalLeaveSL { get; set; }

        public int TotalEL { get; set; }

        public int TotalLeaveEl { get; set; }

        public long ConCode { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }

        public virtual EmployeeDetail EmployeeDetail { get; set; }

        public virtual LeaveSetting LeaveSetting { get; set; }
    }
}
