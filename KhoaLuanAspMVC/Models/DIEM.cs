namespace KhoaLuanAspMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIEM")]
    public partial class DIEM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MASV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string IDHP { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MAHP { get; set; }

        [Column("DIEM")]
        public double? DIEM1 { get; set; }

        public virtual HOCPHAN HOCPHAN { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
