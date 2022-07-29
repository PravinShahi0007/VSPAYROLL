namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LoanDetail
    {
        public long id { get; set; }

        public long EmpCode { get; set; }

        public long LoanCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DueAmount { get; set; }

        public DateTime DueDate { get; set; }

        public bool PaidStatus { get; set; }

        public DateTime? PaidDate { get; set; }

        [StringLength(50)]
        public string PaymentType { get; set; }

        public long ConCode { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }

        public virtual EmployeeDetail EmployeeDetail { get; set; }

        public virtual Loan Loan { get; set; }
    }
}
