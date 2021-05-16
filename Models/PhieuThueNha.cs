using System;
using System.Collections.Generic;

#nullable disable

namespace ThueNha.Models
{
    public partial class PhieuThueNha
    {
        public PhieuThueNha()
        {
            PhieuDiaChis = new HashSet<PhieuDiaChi>();
        }

        public int MaPhieuThueNha { get; set; }
        public int? MaNguoiThue { get; set; }
        public double PhiThueNha { get; set; }
        public double PhiTrachNhiem { get; set; }

        public virtual NguoiThue MaNguoiThueNavigation { get; set; }
        public virtual ICollection<PhieuDiaChi> PhieuDiaChis { get; set; }
    }
}
