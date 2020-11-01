using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class Luong_BUL
    {
        private Luong_DAL l = new Luong_DAL();
        public DataTable getLuong()
        {
            return l.getLuong();
        }
        public DataTable findLuong(string manv, string tennv, string nam, string thang, string socong, string tongluong)
        {
            return l.findLuong(manv, tennv, nam, thang, socong, tongluong);
        }
    }
}
