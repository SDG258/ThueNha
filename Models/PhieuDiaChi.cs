using System;
using System.Collections.Generic;

#nullable disable

namespace ThueNha.Models
{
    public partial class PhieuDiaChi
    {
        public int MaPhieuDiaChi { get; set; }
        public DateTime ThoiGianXemNha { get; set; }
        public int? MaNhaChoThue { get; set; }
        public int? MaPhieuThueNha { get; set; }

        public virtual NhaChoThue MaNhaChoThueNavigation { get; set; }
        public virtual PhieuThueNha MaPhieuThueNhaNavigation { get; set; }
    }
}
