using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu_DTO
    {
        private string tencv;
        private string macv;
        private float hesopc;
        public string Macv { get => macv; set => macv = value; }
        public string Tencv { get => tencv; set => tencv = value; }
        public float Hesopc { get => hesopc; set => hesopc = value; }

        public ChucVu_DTO()
        {

        }
        public ChucVu_DTO(string macv, string tencv, float hesopc)
        {
            this.Macv = macv;
            this.Tencv = tencv;
            this.Hesopc = hesopc;
        }
    }
}
