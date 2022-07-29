namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BiometricMaster")]
    public partial class BiometricMaster
    {
        public int id { get; set; }

        [Required]
        [StringLength(15)]
        public string IPAddress { get; set; }

        public int Port { get; set; }

        public bool Status { get; set; }

        [Required]
        [StringLength(50)]
        public string MachineType { get; set; }

        [Required]
        [StringLength(50)]
        public string Direction { get; set; }

        public long ConCode { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }
    }
}
