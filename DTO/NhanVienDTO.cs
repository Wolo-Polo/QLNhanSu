using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public bool Quyen { get; set; }
        public string MaCV { get; set; }
        public string MaPB { get; set; }
        public NhanVienDTO()
        {

        }
        public NhanVienDTO(string MaNV, string TenNV, string NgaySinh, string GioiTinh, string SDT,  string Email, string TaiKhoan, string MatKhau, bool Quyen, string MaCV, string MaPB)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.SDT = SDT;
            this.Email = Email;
            this.TaiKhoan = TaiKhoan;
            this.MatKhau = MatKhau;
            this.Quyen = Quyen;
            this.MaCV = MaCV;
            this.MaPB = MaPB;
        }
    }
}
