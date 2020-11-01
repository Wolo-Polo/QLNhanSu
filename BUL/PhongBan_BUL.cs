using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUL
{
    public class PhongBan_BUL
    {
        private PhongBan_DAL phongBan_DAL = new PhongBan_DAL();
        public DataTable getAllPhongBan()
        {
            return phongBan_DAL.getAllPhongBan();
        }
        public int insertPhongBan(PhongBan_DTO pb)
        {
            return phongBan_DAL.insertPhongBan(pb);
        }
        public int updatePhongBan(PhongBan_DTO pb)
        {
            return phongBan_DAL.updatePhongBan(pb);
        }
        public int deletePhongBan(string MaPB)
        {
            return phongBan_DAL.deletePhongBan(MaPB);
        }
        public DataTable findPhongBan(PhongBan_DTO pb)
        {
            return phongBan_DAL.findPhongBan(pb);
        }
    }
}
