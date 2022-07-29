namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HolidayMaster")]
    public partial class HolidayMaster
    {
        public long id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(200)]
        public string HolidayName { get; set; }

        public long LeaveTypeCode { get; set; }

        public long ConCode { get; set; }

        public bool Status { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }

        public virtual LeaveType LeaveType { get; set; }
    }
}
