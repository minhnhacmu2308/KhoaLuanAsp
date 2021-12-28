namespace KhoaLuanAspMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            DIEMs = new HashSet<DIEM>();
        }

        [Key]
        [StringLength(20)]
        public string MASV { get; set; }

        [StringLength(100)]
        public string HOTEN { get; set; }

        [Required]
        [StringLength(20)]
        public string MALOP { get; set; }

        [StringLength(10)]
        public string GIOITINH { get; set; }

        public DateTime? NGAYSINH { get; set; }

        public string NOISINH { get; set; }

        public string DIACHI { get; set; }

        [StringLength(100)]
        public string TAIKHOAN { get; set; }

        [StringLength(100)]
        public string MATKHAU { get; set; }

        [Column(TypeName = "ntext")]
        public string GHICHU { get; set; }

        [StringLength(20)]
        public string MACN { get; set; }

        public virtual CHUYENNGANH CHUYENNGANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEM> DIEMs { get; set; }

        public virtual LOP LOP { get; set; }
    }
}
