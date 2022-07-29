namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LeaveSetting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LeaveSetting()
        {
            LeaveOpenings = new HashSet<LeaveOpening>();
        }

        public int Id { get; set; }

        public long CatCode { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public bool CL { get; set; }

        public bool SL { get; set; }

        public bool EL { get; set; }

        public bool CLPM { get; set; }

        public bool CLPY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ClPerMonth { get; set; }

        public bool SLPM { get; set; }

        public bool SLPY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal SlPerMonth { get; set; }

        public bool ELPM { get; set; }

        public bool ELPY { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ElPerMonth { get; set; }

        public long ConCode { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public virtual CategoryMaster CategoryMaster { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveOpening> LeaveOpenings { get; set; }
    }
}
