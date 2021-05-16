using System;
using System.Collections.Generic;

#nullable disable

namespace ThueNha.Models
{
    public partial class NguoiThue
    {
        public NguoiThue()
        {
            PhieuThueNhas = new HashSet<PhieuThueNha>();
        }

        public int MaNguoiThue { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public int Loai { get; set; }
        public int MaPhieuThueNha { get; set; }
        public int Cmnd { get; set; }

        public virtual ICollection<PhieuThueNha> PhieuThueNhas { get; set; }
    }
}
