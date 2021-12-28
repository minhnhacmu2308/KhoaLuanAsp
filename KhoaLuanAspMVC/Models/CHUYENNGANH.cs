namespace KhoaLuanAspMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUYENNGANH")]
    public partial class CHUYENNGANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHUYENNGANH()
        {
            HOCPHANs = new HashSet<HOCPHAN>();
            SINHVIENs = new HashSet<SINHVIEN>();
        }

        [Key]
        [StringLength(20)]
        public string MACN { get; set; }

        public string TENCN { get; set; }

        [StringLength(10)]
        public string MAKHOA { get; set; }

        public virtual KHOA KHOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOCPHAN> HOCPHANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIEN> SINHVIENs { get; set; }
    }
}
