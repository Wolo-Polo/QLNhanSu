using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhongBan_DTO
    {
        public string MaPB { get; set; }
        public string TenPB { get; set; }
        public string NgayTL { get; set; }

        public PhongBan_DTO()
        {

        }
        public PhongBan_DTO(string MaPB, string TenPB, string NgayTL)
        {
            this.MaPB = MaPB;
            this.TenPB = TenPB;
            this.NgayTL = NgayTL;
        }
    }
}
