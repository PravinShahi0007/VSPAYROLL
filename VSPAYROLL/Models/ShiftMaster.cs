namespace VSPAYROLL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShiftMaster")]
    public partial class ShiftMaster
    {
        public int id { get; set; }

        public long BatchCode { get; set; }

        public int ShiftCode { get; set; }

        public DateTime InTime { get; set; }

        public bool InTimeNextDay { get; set; }

        public DateTime? AfterInTimeGrace { get; set; }

        public bool AfterInTimeGraceNextDay { get; set; }

        public DateTime? Break1From { get; set; }

        public bool Break1FromNextDay { get; set; }

        public DateTime? Break1To { get; set; }

        public bool Break1ToNextDay { get; set; }

        public DateTime? LunchFrom { get; set; }

        public bool LunchFromNextDay { get; set; }

        public DateTime? LunchTo { get; set; }

        public bool LunchToNextDay { get; set; }

        public DateTime? Break2From { get; set; }

        public bool Break2FromNextDay { get; set; }

        public DateTime? Break2To { get; set; }

        public bool Break2ToNextDay { get; set; }

        public DateTime OutTime { get; set; }

        public bool OutTimeNextDay { get; set; }

        public DateTime? BeforeOutTime { get; set; }

        public bool BeforeOutTimeNextDay { get; set; }

        public long? Level { get; set; }

        public long ConCode { get; set; }

        public long CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public long? UpdatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public virtual ConcernMaster ConcernMaster { get; set; }
    }
}
