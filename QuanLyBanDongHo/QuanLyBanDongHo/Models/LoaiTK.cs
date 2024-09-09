namespace QuanLyBanDongHo.Modules
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiTK")]
    public partial class LoaiTK
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLTK { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TenLoaiTK { get; set; }
    }
}
