using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongTac_DTO
    {
        public string MaNV { get; set; }
        public string NgayCongTac { get; set; }
        public string NoiCongTac { get; set; }
        public CongTac_DTO()
        {

        }
        public CongTac_DTO(string MaNV, string NgayCongTac, string NoiCongTac)
        {
            this.MaNV = MaNV;
            this.NgayCongTac = NgayCongTac;
            this.NoiCongTac = NoiCongTac;
        }
    }
}
