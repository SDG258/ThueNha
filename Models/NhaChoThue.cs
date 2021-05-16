using System;
using System.Collections.Generic;

#nullable disable

namespace ThueNha.Models
{
    public partial class NhaChoThue
    {
        public NhaChoThue()
        {
            PhieuDangKyChoThues = new HashSet<PhieuDangKyChoThue>();
            PhieuDiaChis = new HashSet<PhieuDiaChi>();
        }

        public int MaNhaChoThue { get; set; }
        public int TrangThaiChoThue { get; set; }
        public double GiaThue { get; set; }
        public string DacDiem { get; set; }
        public string Quan { get; set; }
        public string DiaChi { get; set; }
        public int SoNguoi { get; set; }
        public double DienTich { get; set; }
        public int? Cmnd { get; set; }

        public virtual ChuNha CmndNavigation { get; set; }
        public virtual ICollection<PhieuDangKyChoThue> PhieuDangKyChoThues { get; set; }
        public virtual ICollection<PhieuDiaChi> PhieuDiaChis { get; set; }
    }
}
