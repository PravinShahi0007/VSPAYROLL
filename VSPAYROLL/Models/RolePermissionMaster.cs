namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolePermissionMaster")]
    public partial class RolePermissionMaster
    {
        public long id { get; set; }

        public long ConCode { get; set; }

        public long RoleCode { get; set; }

        public int PageCode { get; set; }

        public bool Create { get; set; }

        public bool Update { get; set; }

        public bool Delete { get; set; }

        public bool View { get; set; }

        public bool Export { get; set; }

        public bool Import { get; set; }

        public short Status { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }

        public virtual RoleMaster RoleMaster { get; set; }
    }
}
