namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PayAttImport
    {
        public long id { get; set; }

        public DateTime PunchDate { get; set; }

        public DateTime PunchDateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Mcid { get; set; }

        [Required]
        [StringLength(50)]
        public string TicketNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Direction { get; set; }

        [StringLength(50)]
        public string Flag { get; set; }

        [StringLength(50)]
        public string IPAddress { get; set; }

        public int LevelCode { get; set; }

        public long ConCode { get; set; }

        public long CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [StringLength(50)]
        public string SerialNo { get; set; }

        [StringLength(50)]
        public string MachineNumber { get; set; }

        public bool? Level { get; set; }

        [StringLength(50)]
        public string TakeFlag { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }
    }
}
