namespace KhoaLuanAspMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOAHOC")]
    public partial class KHOAHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOAHOC()
        {
            CTDAOTAOs = new HashSet<CTDAOTAO>();
            LOPs = new HashSet<LOP>();
        }

        [Key]
        [StringLength(20)]
        public string MAKH { get; set; }

        [StringLength(50)]
        public string TENKH { get; set; }

        [StringLength(20)]
        public string NAMBD { get; set; }

        [StringLength(20)]
        public string NAMKT { get; set; }

        [StringLength(10)]
        public string MAKHOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDAOTAO> CTDAOTAOs { get; set; }

        public virtual KHOA KHOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOP> LOPs { get; set; }
    }
}
