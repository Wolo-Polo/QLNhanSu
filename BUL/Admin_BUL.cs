using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class Admin_BUL
    {
        private Admin_DAL Admin = new Admin_DAL();
        public Boolean Dangnhap(string taikhoan, string matkhau)
        {
            return Admin.Dangnhap(taikhoan, matkhau);
        }
    }
}
