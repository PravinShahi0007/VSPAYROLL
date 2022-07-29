namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdvancePayment")]
    public partial class AdvancePayment
    {
        public long id { get; set; }

        public long AdvanceCode { get; set; }

        public long EmpCode { get; set; }

        public DateTime Date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PaidAmount { get; set; }

        public long ConCode { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public virtual Advance Advance { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }

        public virtual EmployeeDetail EmployeeDetail { get; set; }
    }
}
