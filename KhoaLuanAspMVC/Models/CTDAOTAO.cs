namespace KhoaLuanAspMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTDAOTAO")]
    public partial class CTDAOTAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTDAOTAO()
        {
            HOCPHANs = new HashSet<HOCPHAN>();
        }

        [Key]
        [StringLength(10)]
        public string MACT { get; set; }

        [StringLength(50)]
        public string TENCT { get; set; }

        [StringLength(50)]
        public string TRINHDO { get; set; }

        [StringLength(50)]
        public string NGANHDAOTAO { get; set; }

        [StringLength(50)]
        public string LOAIHINH { get; set; }

        [StringLength(20)]
        public string MAKH { get; set; }

        public virtual KHOAHOC KHOAHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOCPHAN> HOCPHANs { get; set; }
    }
}
