namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserDetail
    {
        public long id { get; set; }

        public long ConCode { get; set; }

        public long RoleCode { get; set; }

        public long? EmpId { get; set; }

        [Required]
        [StringLength(50)]
        public string EmpNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailId { get; set; }

        [Required]
        [StringLength(50)]
        public string PrimaryPassword { get; set; }

        [StringLength(50)]
        public string SecondaryPassword { get; set; }

        public bool Status { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }

        public virtual EmployeeDetail EmployeeDetail { get; set; }

        public virtual RoleMaster RoleMaster { get; set; }
    }
}
