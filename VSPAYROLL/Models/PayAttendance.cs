namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PayAttendance")]
    public partial class PayAttendance
    {
        public long id { get; set; }

        public DateTime? AttDate { get; set; }

        public long? BatchCode { get; set; }

        public int? ShiftCode { get; set; }

        public long? CatCode { get; set; }

        public long? DeptCode { get; set; }

        public long? DesigCode { get; set; }

        public long? EmpCode { get; set; }

        public DateTime? InTime { get; set; }

        public DateTime? Break1To { get; set; }

        public DateTime? Break1From { get; set; }

        public DateTime? LunchTo { get; set; }

        public DateTime? LunchFrom { get; set; }

        public DateTime? Break2To { get; set; }

        public DateTime? Break2From { get; set; }

        public DateTime? OutTime { get; set; }

        public DateTime? OTInTime { get; set; }

        public DateTime? OTBreakFrom { get; set; }

        public DateTime? OTBreakTo { get; set; }

        public DateTime? OTOutTime { get; set; }

        [StringLength(50)]
        public string WeeklyOff { get; set; }

        [StringLength(50)]
        public string LeaveType { get; set; }

        public int? CLDays { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Present { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OT { get; set; }

        public long? ConCode { get; set; }

        public short? Status { get; set; }

        public bool? IsDeleted { get; set; }

        public DateTime? CreatedAt { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public int? LevelCode { get; set; }

        public virtual BatchMaster BatchMaster { get; set; }

        public virtual CategoryMaster CategoryMaster { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }

        public virtual DepartmentMaster DepartmentMaster { get; set; }

        public virtual DesignationMaster DesignationMaster { get; set; }
    }
}
