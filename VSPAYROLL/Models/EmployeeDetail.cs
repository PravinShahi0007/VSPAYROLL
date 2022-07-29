namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmployeeDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeDetail()
        {
            Advances = new HashSet<Advance>();
            AdvancePayments = new HashSet<AdvancePayment>();
            EmpEduDetails = new HashSet<EmpEduDetail>();
            EmpFamilyDetails = new HashSet<EmpFamilyDetail>();
            EmpServiceDetails = new HashSet<EmpServiceDetail>();
            LeaveMasters = new HashSet<LeaveMaster>();
            LeaveMasters1 = new HashSet<LeaveMaster>();
            LeaveOpenings = new HashSet<LeaveOpening>();
            Loans = new HashSet<Loan>();
            LoanDetails = new HashSet<LoanDetail>();
            UserDetails = new HashSet<UserDetail>();
            Wages = new HashSet<Wage>();
        }

        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string EmpNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string EmpName { get; set; }

        [Required]
        [StringLength(50)]
        public string CardNo { get; set; }

        public int Mcid { get; set; }

        public long CatCode { get; set; }

        public long DeptCode { get; set; }

        public long DesigCode { get; set; }

        public long? BatchCode { get; set; }

        [Column(TypeName = "date")]
        public DateTime DOB { get; set; }

        [Column(TypeName = "date")]
        public DateTime DOJ { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DOR { get; set; }

        [StringLength(50)]
        public string ESINo { get; set; }

        public bool ESIEligible { get; set; }

        public DateTime? ESIEffectFrom { get; set; }

        [StringLength(50)]
        public string PFNo { get; set; }

        public bool PFEligible { get; set; }

        [StringLength(50)]
        public string FatherName { get; set; }

        [StringLength(50)]
        public string FatherOccupation { get; set; }

        [StringLength(50)]
        public string Spouse { get; set; }

        [StringLength(100)]
        public string SpouseOccupation { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string EmployeeType { get; set; }

        [Required]
        [StringLength(50)]
        public string PermenantAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string HomeAddress { get; set; }

        [StringLength(50)]
        public string AadharCard { get; set; }

        [StringLength(50)]
        public string PanCard { get; set; }

        public bool Level1Eligible { get; set; }

        public bool Level2Eligible { get; set; }

        public bool AutoShiftRotation { get; set; }

        [Required]
        [StringLength(50)]
        public string WeekOff { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AdvanceLimit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LoanLimit { get; set; }

        public bool Status { get; set; }

        public bool IsDeleted { get; set; }

        public long ConCode { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Advance> Advances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdvancePayment> AdvancePayments { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpEduDetail> EmpEduDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpFamilyDetail> EmpFamilyDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpServiceDetail> EmpServiceDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveMaster> LeaveMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveMaster> LeaveMasters1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveOpening> LeaveOpenings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Loan> Loans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanDetail> LoanDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserDetail> UserDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wage> Wages { get; set; }
    }
}
