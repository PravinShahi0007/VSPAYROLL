namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LeaveMaster")]
    public partial class LeaveMaster
    {
        public long id { get; set; }

        public long LeaveType { get; set; }

        [Required]
        [StringLength(50)]
        public string Reason { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LeaveDuration { get; set; }

        public long EmpNo { get; set; }

        public long? ApprovedBy { get; set; }

        public DateTime? ApprovedAt { get; set; }

        public long? ApprovedType { get; set; }

        public long ConCode { get; set; }

        public bool Status { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public virtual AprovedType AprovedType { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }

        public virtual EmployeeDetail EmployeeDetail { get; set; }

        public virtual EmployeeDetail EmployeeDetail1 { get; set; }

        public virtual LeaveType LeaveType1 { get; set; }
    }
}
