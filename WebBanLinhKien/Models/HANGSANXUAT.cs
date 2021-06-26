namespace WebBanLinhKien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HANGSANXUAT")]
    public partial class HANGSANXUAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HANGSANXUAT()
        {
            PHUKIENs = new HashSet<PHUKIEN>();
        }

        [Key]
        public int MaHSX { get; set; }

        [Required]
        [StringLength(50)]
        public string TenHSX { get; set; }

        [StringLength(200)]
        public string Diachi { get; set; }

        [StringLength(50)]
        public string DienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHUKIEN> PHUKIENs { get; set; }
    }
}
