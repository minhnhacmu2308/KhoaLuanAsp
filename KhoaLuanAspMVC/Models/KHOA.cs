namespace KhoaLuanAspMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOA")]
    public partial class KHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOA()
        {
            CHUYENNGANHs = new HashSet<CHUYENNGANH>();
            KHOAHOCs = new HashSet<KHOAHOC>();
        }

        [Key]
        [StringLength(10)]
        public string MAKHOA { get; set; }

        [StringLength(100)]
        public string TENKHOA { get; set; }

        public string DIACHI { get; set; }

        [StringLength(50)]
        public string SODIENTHOAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHUYENNGANH> CHUYENNGANHs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOAHOC> KHOAHOCs { get; set; }
    }
}
