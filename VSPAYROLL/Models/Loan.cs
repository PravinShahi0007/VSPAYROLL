namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Loan")]
    public partial class Loan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Loan()
        {
            LoanDetails = new HashSet<LoanDetail>();
        }

        public long id { get; set; }

        public long EmpCode { get; set; }

        public DateTime Date { get; set; }

        public DateTime LoanStartDate { get; set; }

        public decimal LoanAmount { get; set; }

        public int Months { get; set; }

        public decimal MonthlyDue { get; set; }

        public long ConCode { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }

        public virtual EmployeeDetail EmployeeDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanDetail> LoanDetails { get; set; }
    }
}
