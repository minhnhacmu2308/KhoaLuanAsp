namespace KhoaLuanAspMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOP")]
    public partial class LOP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOP()
        {
            SINHVIENs = new HashSet<SINHVIEN>();
        }

        [Key]
        [StringLength(20)]
        public string MALOP { get; set; }

        [StringLength(50)]
        public string TENLOP { get; set; }

        [StringLength(20)]
        public string MAKH { get; set; }

        public virtual KHOAHOC KHOAHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIEN> SINHVIENs { get; set; }
    }
}
