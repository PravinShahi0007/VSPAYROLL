namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EmpServiceDetail
    {
        public long id { get; set; }

        public long EmpCode { get; set; }

        [StringLength(50)]
        public string PreviousCompany { get; set; }

        [StringLength(50)]
        public string PreviousCompanyAddress { get; set; }

        public DateTime? JobStart { get; set; }

        public DateTime? JobEnd { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string Experiense { get; set; }

        public long ConCode { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }

        public virtual EmployeeDetail EmployeeDetail { get; set; }
    }
}
