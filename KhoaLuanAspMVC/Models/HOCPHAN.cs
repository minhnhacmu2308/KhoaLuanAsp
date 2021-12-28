namespace KhoaLuanAspMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCPHAN")]
    public partial class HOCPHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOCPHAN()
        {
            DIEMs = new HashSet<DIEM>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string IDHP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MAHP { get; set; }

        [StringLength(50)]
        public string TENHP { get; set; }

        public int? SOTC { get; set; }

        public int? HOCKY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TGBATDAU { get; set; }

        [Column(TypeName = "date")]
        public DateTime? TGKETTHUC { get; set; }

        [StringLength(50)]
        public string HINHTHUC { get; set; }

        [StringLength(50)]
        public string LOAIHP { get; set; }

        [Required]
        [StringLength(10)]
        public string MACT { get; set; }

        [Required]
        [StringLength(20)]
        public string MACN { get; set; }

        public virtual CHUYENNGANH CHUYENNGANH { get; set; }

        public virtual CTDAOTAO CTDAOTAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEM> DIEMs { get; set; }
    }
}
