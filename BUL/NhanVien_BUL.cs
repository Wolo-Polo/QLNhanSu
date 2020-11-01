using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class NhanVien_BUL
    {
        private NhanVien_DAL nhanVien_DAL = new NhanVien_DAL();
        public DataTable getAllNhanVien()
        {
            return nhanVien_DAL.getAllNhanVien();
        }
        public int insertNhanVien(NhanVienDTO nv)
        {
            return nhanVien_DAL.insertNhanVien(nv);
        }
        public int updateNhanVien(NhanVienDTO nv)
        {
            return nhanVien_DAL.updateNhanVien(nv);
        }
        public int deleteNhanVien(string manv)
        {
            return nhanVien_DAL.deleteNhanVien(manv);
        }
        public DataTable findNhanVien(NhanVienDTO nv)
        {
            return nhanVien_DAL.timkiemNhanVien(nv);
        }
        public DataTable getNhanVienbyPhongBan(string mapb)
        {
            return nhanVien_DAL.getNhanVienbyPhongBan(mapb);
        }
    }
}
