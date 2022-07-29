namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LevelMaster")]
    public partial class LevelMaster
    {
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string LevelName { get; set; }

        public bool Status { get; set; }

        public long ConCode { get; set; }

        public long CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }
    }
}
