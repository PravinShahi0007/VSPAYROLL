namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ESIPFSetting
    {
        public int id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ESIPercentange { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ESIMinLimit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ESIMaxLimit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ESIEmployer { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ESIEmployes { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PFPercentange { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PFMinLimit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PFMaxLimit { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EPS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EPF { get; set; }

        public long ConCode { get; set; }

        public DateTime CreatedAt { get; set; }

        public long CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public long? UpdatedBy { get; set; }
    }
}
