namespace QuanLyBanDongHo.Modules
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DongHo")]
    public partial class DongHo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DongHo()
        {
            GioHangs = new HashSet<GioHang>();
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDongHo { get; set; }

        [Required]
        [StringLength(200)]
        public string TenDongHo { get; set; }

        [Required]
        [StringLength(200)]
        public string LoaiDongHo { get; set; }

        [Required]
        [StringLength(200)]
        public string HangDongHo { get; set; }

        public int SoLuong { get; set; }

        public double DonGia { get; set; }

        [Required]
        public string HinhAnh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioHang> GioHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
