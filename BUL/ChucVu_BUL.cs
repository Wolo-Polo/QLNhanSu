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
    public class ChucVu_BUL
    {
        private ChucVu_DAL cv = new ChucVu_DAL();
        public DataTable getAllChucVu()
        {
            return cv.getAllChucVu();
        }
        public Boolean insertChucVu(ChucVu_DTO c)
        {
            return cv.insertChucVu(c);
        }
        public Boolean updateChucVu(ChucVu_DTO c) {
            return cv.updateChucVu(c);
        }
        public Boolean deleteChucVu(ChucVu_DTO c) {
            return cv.deleteChucVu(c);
        }
        public DataTable findChucVu(string macv,string tencv, string hesopc)
        {
            return cv.findChucVu(macv,tencv,hesopc);
        }
    }
}
