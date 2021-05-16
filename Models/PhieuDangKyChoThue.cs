using System;
using System.Collections.Generic;

#nullable disable

namespace ThueNha.Models
{
    public partial class PhieuDangKyChoThue
    {
        public PhieuDangKyChoThue()
        {
            PhieuKhaoSats = new HashSet<PhieuKhaoSat>();
        }

        public int MaDk { get; set; }
        public DateTime NgayDk { get; set; }
        public DateTime NgayKt { get; set; }
        public double PhiGioiThieu { get; set; }
        public int? MaNhaChoThue { get; set; }

        public virtual NhaChoThue MaNhaChoThueNavigation { get; set; }
        public virtual ICollection<PhieuKhaoSat> PhieuKhaoSats { get; set; }
    }
}
