namespace WebBanLinhKien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHUKIEN")]
    public partial class PHUKIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHUKIEN()
        {
            CHITIETDONTHANGs = new HashSet<CHITIETDONTHANG>();
        }

        [Key]
        public int MaPK { get; set; }

        [Required]
        [StringLength(100)]
        public string TenPK { get; set; }

        public decimal? Giaban { get; set; }

        public string Mota { get; set; }

        [StringLength(50)]
        public string Anhbia { get; set; }

        public DateTime? Ngaycapnhat { get; set; }

        public int? Soluongton { get; set; }

        public int? MaCD { get; set; }

        public int? MaHSX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONTHANG> CHITIETDONTHANGs { get; set; }

        public virtual CHUDE CHUDE { get; set; }

        public virtual HANGSANXUAT HANGSANXUAT { get; set; }
    }
}
