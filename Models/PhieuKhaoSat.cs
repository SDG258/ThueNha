using System;
using System.Collections.Generic;

#nullable disable

namespace ThueNha.Models
{
    public partial class PhieuKhaoSat
    {
        public int MaPkx { get; set; }
        public int TrangThai { get; set; }
        public string GhiChu { get; set; }
        public int? MaDk { get; set; }

        public virtual PhieuDangKyChoThue MaDkNavigation { get; set; }
    }
}
