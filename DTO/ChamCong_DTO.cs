using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChamCong_DTO
    {
        private string manv;
        private string ngaycong;
        private string ghichu;

        public ChamCong_DTO()
        {

        }

        public ChamCong_DTO(string manv, string ngaycong, string ghichu)
        {
            this.Manv = manv;
            this.Ngaycong = ngaycong;
            this.Ghichu = ghichu;
        }

        public string Manv { get => manv; set => manv = value; }
        public string Ngaycong { get => ngaycong; set => ngaycong = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
