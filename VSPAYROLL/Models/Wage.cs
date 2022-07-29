namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wage
    {
        public long id { get; set; }

        public long EmpCode { get; set; }

        public long ConCode { get; set; }

        public long CatCode { get; set; }

        public long DeptCode { get; set; }

        public long DesigCode { get; set; }

        [Required]
        [StringLength(50)]
        public string WagesType { get; set; }

        public DateTime EffectiveDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal BasicSalary { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DearnessAllowance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal HouseRentAllowance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ConveyanceAllowance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal LeaveTravelAllowance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal MedicalAllowance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PerformanceBonusAndSpecialAllowance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal OtherAllowances { get; set; }

        public short Status { get; set; }

        public long LevelCode { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public virtual CategoryMaster CategoryMaster { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }

        public virtual DepartmentMaster DepartmentMaster { get; set; }

        public virtual DesignationMaster DesignationMaster { get; set; }

        public virtual EmployeeDetail EmployeeDetail { get; set; }
    }
}
