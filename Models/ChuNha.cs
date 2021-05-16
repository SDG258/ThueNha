using System;
using System.Collections.Generic;

#nullable disable

namespace ThueNha.Models
{
    public partial class ChuNha
    {
        public ChuNha()
        {
            NhaChoThues = new HashSet<NhaChoThue>();
        }

        public int Cmnd { get; set; }
        public string HoTen { get; set; }
        public string Sdt { get; set; }

        public virtual ICollection<NhaChoThue> NhaChoThues { get; set; }
    }
}
